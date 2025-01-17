using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 时间轴
/// </summary>
public class ShiJianZou : MonoBehaviour
{
    [Header("界面")]
    public GameObject jieMian;
    [Header("时间轴年份")]
    public GameObject[] shiJianZou_NianFen;

    [Header("退出视角视角")]
    public CinemachineVirtualCameraBase vcam_SanDa;
    void Start()
    {
        
    }
    /// <summary>
    /// 初始化数据
    /// </summary>
    public void ChuShiHua()
    {

        jieMian.SetActive(true);
    }

    /// <summary>
    /// 点击年份
    /// </summary>
    /// <param name="data"></param>
    public void OnClick_NianFen(int data)
    {
        foreach (var item in shiJianZou_NianFen)
        {
            item.SetActive(false);
        }
        shiJianZou_NianFen[data].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 退出游戏
    /// </summary>
    public void EntGame()
    {
        vcam_SanDa.MoveToTopOfPrioritySubqueue();
        if (jieMian)
        {
            jieMian.SetActive(false);
        }
      
    }
}
