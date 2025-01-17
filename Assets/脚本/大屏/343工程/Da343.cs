using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 大屏343工程
/// </summary>
public class Da343 : MonoBehaviour
{
    [Header("三大绿能基地界面")]
    public GameObject sanDa_UI;
    [Header("四项技术保障界面")]
    public GameObject shiXiang_UI;
    [Header("模型相机")]
    public GameObject modelCamera;

    [Header("模型")]
    public GameObject model;
    [Header("默认视角")]
    public CinemachineVirtualCameraBase vcam;

    [Header("三大视角")]
    public CinemachineVirtualCameraBase vcam_SanDa;
    void Start()
    {
        
    }
    /// <summary>
    /// 选择343
    /// </summary>
    public void Start343()
    {
        model.SetActive(true);
        modelCamera.SetActive(true);
        sanDa_UI.SetActive(false);
        shiXiang_UI.SetActive(false);
        
        vcam.MoveToTopOfPrioritySubqueue();
    }
    /// <summary>
    /// 退出343
    /// </summary>
    public void TuiChu343()
    {
        print("退出343");
        //model.SetActive(true);
        //modelCamera.SetActive(true);
        sanDa_UI.SetActive(false);
        shiXiang_UI.SetActive(false);
        vcam.MoveToTopOfPrioritySubqueue();
    }
    /// <summary>
    /// 显示三大
    /// </summary>
    public void XianShi_SanDa()
    {
        sanDa_UI.SetActive(true);
        shiXiang_UI.SetActive(false);
        vcam_SanDa.MoveToTopOfPrioritySubqueue();
    }

    /// <summary>
    /// 显示四项
    /// </summary>
    public void XianShi_ShiXiang()
    {
        sanDa_UI.SetActive(false);
        shiXiang_UI.SetActive(true);
    }

    void Update()
    {
        
    }
}
