using System.Collections;
using System.Collections.Generic;
using LuaFramework;
using UnityEngine;
using UnityEngine.UI;

public class BlurTest : MonoBehaviour
{
    public GameObject blurImg;

    public float blurRange = 2.0f;

    private void Start()
    {
        blurImg.GetComponent<RawImage>().texture = Resources.Load<Texture>("RenderTexture/blurTex");
    }

    //改变模糊状态
    public void ChangeBlurState()
    {
        LuaHelper.blurDrawing = !LuaHelper.blurDrawing;
//        print("ChangeBlurState - " + LuaHelper.blurDrawing);
        blurImg.SetActive(LuaHelper.blurDrawing);
    }

    private void Update()
    {
        LuaHelper.DrawBlurTextureToggle(LuaHelper.blurDrawing, blurRange);
    }
}
