using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 令牌界面的切换
/// </summary>
public class LingPai_UI : MonoBehaviour
{
    [Header("令牌1待机")]
    public GameObject ling_1_DaiJi;
    [Header("全屏按钮")]
    public GameObject quanPingButton;
    [Header("缩小按钮")]
    public GameObject suoXiaoButton;
    [Header("令牌2所有界面")]
    public GameObject[] ling_2_ALL;
    // Start is called before the first frame update
    void Start()
    {
        quanPingButton.SetActive(true);
        suoXiaoButton.SetActive(false);
    }
    /// <summary>
    /// 放置令牌1
    /// </summary>
    public void FangZhi()
    {
        ling_1_DaiJi.SetActive(false);
        quanPingButton.SetActive(true);
        suoXiaoButton.SetActive(false);
        foreach (var item in ling_2_ALL)
        {
            item.SetActive(true);
        }
    }
    /// <summary>
    /// 抬起令牌
    /// </summary>
    public void TaiQi()
    {
        ling_1_DaiJi.SetActive(true);
        quanPingButton.SetActive(true);
        suoXiaoButton.SetActive(false);
        foreach (var item in ling_2_ALL)
        {
            item.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
