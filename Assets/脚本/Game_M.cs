using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// 游戏管理员
/// </summary>
public class Game_M : MonoBehaviour
{
    public static Game_M initialize;
    private void Awake()
    {
        initialize = this;
    }
    /// <summary>
    /// 主界面
    /// </summary>
    public GameObject[] zhuUI;


    public TongBu_BiaoQian[] tongBu_BiaoQians;

    /// <summary>
    /// 是否放置了令牌
    /// </summary>
    bool isFangZhi = false;
    [Header("进入一级页面")]
    public UnityEvent startYiJi;
    [Header("退出一级页面")]
    public UnityEvent entYiJi;
    [Header("待机界面")]
    public GameObject daiJiUI;

    [Header("大屏地图")]
    public GameObject daPingDiTu;
    [Header("沙盘相机")]
    public GameObject shaPanXiangJi;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /// <summary>
    /// 放下了
    /// </summary>
    public void OnClick_D_LingPai()
    {
        if (!isFangZhi)
        {
            //关闭主界面
            foreach (var item in zhuUI)//关闭主界面
            {
                item.SetActive(false);
            }
            isFangZhi = true;
            //显示待机界面
            daiJiUI.SetActive(true);
            daPingDiTu.SetActive(true);
            shaPanXiangJi.SetActive(true);
            startYiJi.Invoke();
        }
    
    }
    /// <summary>
    /// 抬起了
    /// </summary>
    public void OnClick_UP_LingPai()
    {
        //所有令牌都拿开了
        foreach (var item in tongBu_BiaoQians)
        {
            if (item.isXianShi)
            {
                return;
            }
        }
        foreach (var item in zhuUI)
        {
            item.SetActive(true);
        }
        isFangZhi = false;
        daPingDiTu.SetActive(false);
        //关闭待机
        daiJiUI.SetActive(false);
        entYiJi.Invoke();
        shaPanXiangJi.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
