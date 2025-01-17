using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cinemachine;
/// <summary>
/// 大屏 碳补存
/// </summary>
public class TanBuCun_DaPing : MonoBehaviour
{

    [Header("界面")]
    public GameObject jieMian;

    [Header("相机原点")]
    public GameObject cameraYuanDian;
    [Header("地图碳基础")]
    public GameObject diTu_Tan_Ji;


    [Header("地图碳上升")]
    public GameObject diTu_Tan;
    [Header("特效")]
    public GameObject teXiao;

    [Header("地图")]
    public GameObject diTu;
    [Header("地图平面")]
    public GameObject diTu_BeiJing;
    [Header("相机")]
    public CinemachineVirtualCameraBase vcam_WeiZhi;

    public CinemachineBrain newCamera;
    /// <summary>
    /// 开始
    /// </summary>
    public void StartGame()
    {
        newCamera.m_DefaultBlend.m_Time=0;
        vcam_WeiZhi.MoveToTopOfPrioritySubqueue();

        diTu_Tan_Ji.SetActive(true);
        jieMian.SetActive(true);
        diTu.SetActive(false);
        diTu_BeiJing.SetActive(false);
        YiDong();
        Invoke("XianShiTeXiao", 1.5f);
    }
    /// <summary>
    /// 显示特效
    /// </summary>
    public void XianShiTeXiao()
    {
        teXiao.SetActive(true);
    }
    /// <summary>
    /// 移动相机视角
    /// </summary>
    public void YiDong()
    {
        diTu_Tan.transform.localPosition = new Vector3(0, 0, 0);
        diTu_Tan.transform.DOLocalMove(new Vector3(0, 30, 0), 1);
        cameraYuanDian.transform.localPosition = new Vector3(0, 0, 0);
        cameraYuanDian.transform.DOLocalMove(new Vector3(0, 30, 0), 1);
        cameraYuanDian.transform.localEulerAngles = new Vector3(0, 0, 0);
        cameraYuanDian.transform.DOLocalRotate(new Vector3(0, 180, 0), 1);
    }
    /// <summary>
    /// 结束
    /// </summary>
    public void EntGame()
    {
        newCamera.m_DefaultBlend.m_Time = 1;
        jieMian.SetActive(false);
        diTu.SetActive(true);
        diTu_BeiJing.SetActive(true);
        diTu_Tan_Ji.SetActive(false);
    }
}
