using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// 中长期  地热大屏
/// </summary>
public class DiReGongLuan_DaPing : MonoBehaviour
{
    [Header("界面")]
    public GameObject jieMian;
    [Header("所有模型")]
    public GameObject[] models;
    [Header("初始位置")]
    public CinemachineVirtualCameraBase[] vcam_WeiZhi;
    [Header("默认视角")]
    public CinemachineVirtualCameraBase vcam_moRen;
    //[Header("相机默认初始角度")]
    //public Vector3[] cameraMoRenJiaoDu;
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

        //切换UI
        foreach (var item in zuoBiao)
        {
            item.SetActive(false);
        }
        foreach (var item in youTanChuang)
        {
            item.SetActive(false);
        }
        // vcam_WeiZhi[data].transform.localEulerAngles = cameraMoRenJiaoDu[data];
        zuoBiao[data].SetActive(true);
        youTanChuang[data].SetActive(true);



        if (data==0)//小区
        {
            if (id_JiLu==1)//供暖
            {
                models[0].SetActive(true);
                models[1].SetActive(true);
                models[1].transform.GetChild(0).localPosition = new Vector3(0, 2, 0);
                models[1].transform.GetChild(0).DOLocalMove(new Vector3(0, 0, 0), 1).OnComplete(() => {

                });
                vcam_WeiZhi[0].MoveToTopOfPrioritySubqueue();//切换到小区俯视视角
                CancelInvoke();
                Invoke("QieHuanMoXing", 1.2f);

            }
            else if (id_JiLu==2)//换热站
            {
                id_JiLu = data;
                vcam_WeiZhi[data].MoveToTopOfPrioritySubqueue();
                CancelInvoke();
                Invoke("QieHuanMoXing", 0f);
            }

        }
        else if (data == 1)//供暖
        {
            if (id_JiLu == 0)//小区
            {
                vcam_WeiZhi[0].MoveToTopOfPrioritySubqueue();//切换到小区俯视视角
                CancelInvoke();
                models[0].SetActive(true);
                models[1].SetActive(true);
                models[1].transform.GetChild(0).localPosition = new Vector3(0, 0, 0);
                Invoke("QieHuanMoXing", 1.2f);
                models[1].transform.GetChild(0).DOLocalMove(new Vector3(0, 2, 0), 1).OnComplete(()=> {
                    //切换视角
                    vcam_WeiZhi[data].MoveToTopOfPrioritySubqueue();
                });
            }
            else if (id_JiLu == 2)
            {
                id_JiLu = data;
                vcam_WeiZhi[data].MoveToTopOfPrioritySubqueue();
                CancelInvoke();
                Invoke("QieHuanMoXing", 0f);
            }
        }
        else//换热站
        {
            if (id_JiLu<0)
            {
                vcam_WeiZhi[data].MoveToTopOfPrioritySubqueue();
                id_JiLu = data;
                QieHuanMoXing();
                Invoke("QieHuanMoXing", 0f);
            }
            else
            {
                id_JiLu = data;
                vcam_WeiZhi[data].MoveToTopOfPrioritySubqueue();
                CancelInvoke();
                Invoke("QieHuanMoXing", 0f);
            }
       
        }
        
        id_JiLu = data;

    }
    /// <summary>
    /// 切换显示的模型
    /// </summary>
    public void QieHuanMoXing()
    {
        if (id_JiLu<0)
        {
            return;
        }
        //切换模型
        foreach (var item in models)
        {
            item.SetActive(false);
        }
        models[id_JiLu].SetActive(true);
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
        vcam_moRen.MoveToTopOfPrioritySubqueue();


        id_JiLu = -1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
