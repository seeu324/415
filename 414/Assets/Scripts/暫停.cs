using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 暫停 : MonoBehaviour
{
    [Header("暫停介面")]
    public Image  imagePause;
    public Sprite spritPause, spritPLAY;

    /// <summary>
    /// 暫停方法
    /// </summary>
	// Use this for initialization
	private void pause()
    {

    }
    //更新:一秒執行約60次
    private void Update()
    {
        pause();
    }
}

