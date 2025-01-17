using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 进入待机界面
/// </summary>
public class DaiJiUI : MonoBehaviour
{
    [Header("显示的ui")]
    public GameObject[] xianShi;
    [Header("隐藏的ui")]
    public GameObject[] yinChang;

    [Header("343一级按钮")]
    public GameObject button343;
    [Header("中长期一级按钮")]
    public GameObject button_zhongChangQi;
    [Header("二级按钮提示")]
    public GameObject button_DongHua;

    public void OnEnable()
    {
        foreach (var item in xianShi)
        {
            if (item!=null)
            {
                item.SetActive(true);
            }
        }


        foreach (var item in yinChang)
        {
            if (item != null)
            {
                item.SetActive(false);
            }
        }
    }
    /// <summary>
    /// 进入343
    /// </summary>
    public void JingRu_343()
    {
        button343.SetActive(true);
        button_zhongChangQi.SetActive(false);
        button_DongHua.SetActive(false);
    }
    /// <summary>
    /// 退出343
    /// </summary>
    public void TuiChu_343()
    {


        //初始化待机界面
        OnEnable();
    }

    /// <summary>
    /// 进入中长期
    /// </summary>
    public void JingRu_ChangQi()
    {
        button343.SetActive(false);
        button_zhongChangQi.SetActive(true);
        button_DongHua.SetActive(false);
    }
    /// <summary>
    /// 退出中长期
    /// </summary>
    public void TuiChu_ChangQi()
    {

        //初始化待机界面
        OnEnable();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
