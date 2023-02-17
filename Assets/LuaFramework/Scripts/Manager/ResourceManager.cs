
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LuaFramework;
using LuaInterface;
using UObject = UnityEngine.Object;

namespace LuaFramework
{
    public class ResourceManager : Manager
    {
        private string[] m_Variants = { };
        private AssetBundleManifest manifest;
        private AssetBundle shared, assetbundle;
        
        //已经加载好的bundle
        private Dictionary<string, AssetBundle> bundles;


        /// <summary>
        /// 初始化
        /// </summary>
        public void Initialize()
        {
            string uri = string.Empty;
            bundles = new Dictionary<string, AssetBundle>();
            uri = Util.DataPath + AppConst.AssetDir;
//            Debug.LogWarning("ResourceManager - " + Application.streamingAssetsPath);
            if (AppConst.BundleMode == false || !File.Exists(uri)) return;
            var fileStream = new FileStream(uri, FileMode.Open, FileAccess.Read);
            assetbundle = AssetBundle.LoadFromStream(fileStream); //关联数据的素材绑定
            manifest = assetbundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
            assetbundle.Unload(false);
            
        }

        public T LoadAnythingAtPath<T>(string assetPath) where T:UnityEngine.Object
        {
            if (AppConst.BundleMode == true)
            {
                string buldleName = assetPath.Replace('\\', '^').Replace('/', '^');
                string assetName = buldleName.Substring(buldleName.LastIndexOf("^") + 1);
                assetName = assetName.Substring(0, assetName.IndexOf("."));
                buldleName = buldleName.Substring(0, buldleName.LastIndexOf("^"));
//                Debug.LogWarning("LoadPrefabAtPath - " + assetPath + " - " + buldleName + " - " + assetName);
                return LoadAsset<T>(buldleName, assetName);
            }
            else
            {
#if UNITY_EDITOR
                return UnityEditor.AssetDatabase.LoadAssetAtPath<T>("Assets/" + AppConst.ResPathHead + assetPath);
#else
                return null;
#endif
            }
        }

        public GameObject LoadPrefabAtPath(string assetPath)
        {
            return LoadAnythingAtPath<GameObject>(assetPath);
        }

        public Object LoadAssetsAtPath(string assetPath)
        {
            return LoadAnythingAtPath<Object>(assetPath);
        }

        public Material LoadMaterialAtPath(string assetPath)
        {
            return LoadAnythingAtPath<Material>(assetPath);
        }
        public Sprite LoadSpriteAtPath(string assetPath)
        {
            return LoadAnythingAtPath<Sprite>(assetPath);
        }
        /// <summary>
        /// 载入素材
        /// </summary>
        public T LoadAsset<T>(string abname, string assetname) where T : UnityEngine.Object
        {
            abname = abname.ToLower();
            AssetBundle bundle = LoadAssetBundle(abname, false);
            //TODO 加载完最后读取有问题
            T obj = bundle.LoadAsset<T>(assetname);
//            Debug.LogWarning("LoadAsset - " + abname + " - " + assetname + " - " + obj);
            return obj;
        }

        private Dictionary<string, List<LuaFunction>> ABCallBacks = new Dictionary<string, List<LuaFunction>>();
        /// <summary>
        /// 载入AssetBundle
        /// </summary>
        /// <param name="abname"></param>
        /// <returns></returns>
        public AssetBundle LoadAssetBundle(string abname, bool async, LuaFunction callBack = null)
        {
            if (!abname.EndsWith(AppConst.ExtName))
            {
                abname += AppConst.ExtName;
            }

            AssetBundle bundle = null;
            if (!bundles.ContainsKey(abname))
            {
                
//                Debug.Log("LoadAssetBundle " + abname + " " + async);
                if (async == true)
                {
                    if (_waitingDepends.ContainsKey(abname) == true || _loadingAssets.ContainsKey(abname) == true)
                    {
                        return null;
                    }

                    if (callBack != null)
                    {
                        if (ABCallBacks.ContainsKey(abname) == false)
                        {
                            ABCallBacks[abname] = new List<LuaFunction>();
                        }
                        ABCallBacks[abname].Add(callBack);
                    }


                    StartCoroutine(LoadAssetBundleAsync(abname));
                }
                else
                {
                    string uri = Util.DataPath + abname;
                    string[] dependencies = GetDependencies(abname);

                    if (dependencies != null)
                    {
                        // Record and load all dependencies.
                        for (int i = 0; i < dependencies.Length; i++)
                        {
                            LoadAssetBundle(dependencies[i], async);
                        }
                    }

                    var fileStream = new FileStream(uri, FileMode.Open, FileAccess.Read);
                    bundle = AssetBundle.LoadFromStream(fileStream); //关联数据的素材绑定
//                AssetBundle.LoadFromStreamAsync()
//                    Debug.LogWarning("LoadAssetBundle - " + abname + " - " + uri + " - " + bundle);
                    bundles[abname] = bundle;
                    // bundle.Unload(false);
                }
            }
            else
            {
                bundles.TryGetValue(abname, out bundle);
                // Debug.Log("LoadAssetBundle 资源已经存在" + abname + " " + async + " " + bundle);
                if (callBack != null)
                {
                    callBack.Call();
                }
            }

            return bundle;
        }

        /// <summary>
        /// 获取AB包的加载中信息
        /// </summary>
        /// <param name="abname"></param>
        /// <returns></returns>
        public AssetBundleCreateRequest GetLoadingRequestInfo(string abname)
        {
            if (_loadingAssets.ContainsKey(abname) == false)
            {
                return null;
            }

            return _loadingAssets[abname];
        }

        /// <summary>
        /// 获取依赖包的加载中信息
        /// </summary>
        /// <param name="abname"></param>
        /// <returns></returns>
        public string[] GetLoadingDependsList(string abname)
        {
            
            if (_depends.ContainsKey(abname) == false)
            {
                return null;
            }

            return _depends[abname];
        }

        private Dictionary<string, AssetBundleCreateRequest> _loadingAssets = new Dictionary<string, AssetBundleCreateRequest>();
        private Dictionary<string, AssetBundleCreateRequest> _waitingDepends = new Dictionary<string, AssetBundleCreateRequest>();
        private Dictionary<string, string[]> _depends = new Dictionary<string, string[]>();

        IEnumerator LoadAssetBundleAsync(string abname)
        {
            string uri = Util.DataPath + abname;
            var fileStream = new FileStream(uri, FileMode.Open, FileAccess.Read);
            AssetBundleCreateRequest abRequest = AssetBundle.LoadFromStreamAsync(fileStream); //关联数据的素材绑定
            
            _loadingAssets[abname] = abRequest;
            
            string[] dependencies = GetDependencies(abname);

            if (dependencies != null)
            {
                for (int i = 0; i < dependencies.Length; i++)
                {
                    LoadAssetBundle(dependencies[i], true);
                } 
            }
            
            yield return abRequest;
            _loadingAssets.Remove(abname);
            
            
            bool dependsOK = true;
            if (dependencies != null)
            {
                for (int i = 0; i < dependencies.Length; i++)
                {
                    if (bundles.ContainsKey(dependencies[i]) == false)
                    {
                        dependsOK = false;
                        break;
                    }
                }
            }

            if (dependsOK == true)
            {
                print("LoadAssetBundleAsync 依赖已经加载好了" + abname);
                bundles[abname] = abRequest.assetBundle;
                if (ABCallBacks.ContainsKey(abname) == true)
                {
                    for (int i = 0; i < ABCallBacks[abname].Count; i++)
                    {
                        ABCallBacks[abname][i].Call();
                    }

                    ABCallBacks.Remove(abname);
                }
            }
            else
            {
                print("LoadAssetBundleAsync 还要等待依赖资源的加载" + abname + "  " + dependencies.Length);
                _waitingDepends[abname] = abRequest;
                _depends[abname] = dependencies;
            }
            
            CheckWaitingDepends();
            yield return null;

        }

        /*
         * 每次有异步加载完成 判断是否有父级完成
         */
        private void CheckWaitingDepends()
        {
            List<string> okList = new List<string>();
            foreach (KeyValuePair<string, AssetBundleCreateRequest> kvp in _waitingDepends)
            {
                string[] dependencies = _depends[kvp.Key];
                bool dependsOK = true;
                for (int i = 0; i < dependencies.Length; i++)
                {
                    if (bundles.ContainsKey(dependencies[i]) == false && _waitingDepends.ContainsKey(dependencies[i]) == false)
                    {
                        dependsOK = false;
                        break;
                    }
                }

                if (dependsOK == true)
                {
                    okList.Add(kvp.Key);
                    bundles[kvp.Key] = kvp.Value.assetBundle;
                }
            }

            for (int i = 0; i < okList.Count; i++)
            {
                string abname = okList[i];
                print("CheckWaitingDepends 等到依赖了 " + abname);
                _waitingDepends.Remove(abname);
                _depends.Remove(abname);
                
                if (ABCallBacks.ContainsKey(abname) == true)
                {
                    for (int j = 0; j < ABCallBacks[abname].Count; j++)
                    {
                        ABCallBacks[abname][j].Call();
                    }

                    ABCallBacks.Remove(abname);
                }
            }
        }

        /// <summary>
        /// 载入依赖
        /// </summary>
        /// <param name="name"></param>
        string[] GetDependencies(string name)
        {
            if (manifest == null)
            {
                Debug.LogError("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()");
                return null;
            }

            // Get dependecies from the AssetBundleManifest object..
            string[] dependencies = manifest.GetAllDependencies(name);
            if (dependencies.Length == 0) return null;

            for (int i = 0; i < dependencies.Length; i++)
            {
                dependencies[i] = RemapVariantName(dependencies[i]);
            }


            return dependencies;
        }

        // Remaps the asset bundle name to the best fitting asset bundle variant.
        string RemapVariantName(string assetBundleName)
        {
            string[] bundlesWithVariant = manifest.GetAllAssetBundlesWithVariant();

            // If the asset bundle doesn't have variant, simply return.
            if (System.Array.IndexOf(bundlesWithVariant, assetBundleName) < 0)
                return assetBundleName;

            string[] split = assetBundleName.Split('.');

            int bestFit = int.MaxValue;
            int bestFitIndex = -1;
            // Loop all the assetBundles with variant to find the best fit variant assetBundle.
            for (int i = 0; i < bundlesWithVariant.Length; i++)
            {
                string[] curSplit = bundlesWithVariant[i].Split('.');
                if (curSplit[0] != split[0])
                    continue;

                int found = System.Array.IndexOf(m_Variants, curSplit[1]);
                if (found != -1 && found < bestFit)
                {
                    bestFit = found;
                    bestFitIndex = i;
                }
            }

            if (bestFitIndex != -1)
                return bundlesWithVariant[bestFitIndex];
            else
                return assetBundleName;
        }

        /// <summary>
        /// 销毁资源
        /// </summary>
        void OnDestroy()
        {
            if (shared != null) shared.Unload(true);
            if (manifest != null) manifest = null;
            Debug.Log("~ResourceManager was destroy!");
        }
    }
}