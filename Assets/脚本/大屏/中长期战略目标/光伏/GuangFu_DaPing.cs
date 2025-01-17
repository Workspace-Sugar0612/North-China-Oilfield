using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuangFu_DaPing : MonoBehaviour
{
    [Header("界面")]
    public GameObject jieMian;
    [Header("所有模型")]
    public GameObject[] models;
    [Header("初始位置")]
    public CinemachineVirtualCameraBase[] vcam_WeiZhi;
    [Header("地图")]
    public GameObject diTu;
    [Header("地图")]
    public GameObject diTu_BeiJing;

    [Header("左边标志")]
    public GameObject[] zuoBiao;
    [Header("右弹窗")]
    public GameObject[] youTanChuang;
    // Start is called before the first frame update
    void Start()
    {

    }
    [Header("记录当前切换ID")]
    public int id_JiLu;

    /// <summary>
    /// 点击
    /// </summary>
    /// <param name="data"></param>
    public void OnClick(int data)
    {

      

        id_JiLu = data;
        foreach (var item in models)
        {
            item.SetActive(true);
        }
        vcam_WeiZhi[data].MoveToTopOfPrioritySubqueue();
        for (int i = 0; i < zuoBiao.Length; i++)
        {
            zuoBiao[i].SetActive(i == data);
        }
        for (int i = 0; i < youTanChuang.Length; i++)
        {
            youTanChuang[i].SetActive(i == data);
        }
    }

    /// <summary>
    /// 开始
    /// </summary>
    public void StartGame()
    {
        jieMian.SetActive(true);
        diTu.SetActive(false);
        diTu_BeiJing.SetActive(false);
    }
    /// <summary>
    /// 结束
    /// </summary>
    public void EntGame()
    {
        jieMian.SetActive(false);
        diTu.SetActive(true);
        diTu_BeiJing.SetActive(true);
        foreach (var item in models)
        {
            item.SetActive(false);
        }


        id_JiLu = -1;
    }

}
