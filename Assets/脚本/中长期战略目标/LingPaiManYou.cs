using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 令牌漫游
/// </summary>
public class LingPaiManYou : MonoBehaviour
{
    [Header("UI上")]
    public GameObject uiShang;
    [Header("UI下")]
    public GameObject uiXia;
    [Header("UI左")]
    public GameObject uiZuo;
    [Header("UI右")]
    public GameObject uiYou;


    [Header("图上")]
    public GameObject tuShang;
    [Header("图下")]
    public GameObject tuXia;
    [Header("图左")]
    public GameObject tuZuo;
    [Header("图右")]
    public GameObject tuYou;


    [Header("令牌")]
    public GameObject lingPai;
    [Header("令牌转化位置")]
    public GameObject lingPaiZhuanHua;

    [Header("计算相机")]
    public GameObject xiangJi;
    [Header("令牌按钮")]
    public lingPaiButton lingPaiButton;

    [Header("默认视角")]
    public CinemachineVirtualCameraBase cameraBase_MoRen;

    [Header("漫游视角")]
    public CinemachineVirtualCameraBase cameraBase_ManYou;
    /// <summary>
    /// 开始令牌
    /// </summary>
    public void StartLingPai()
    {
        lingPai = lingPaiButton.muBiao;

        cameraBase_ManYou.MoveToTopOfPrioritySubqueue();
    }
    /// <summary>
    /// 结束令牌
    /// </summary>
    public void EntLingPai()
    {
        lingPai = null;
        cameraBase_MoRen.MoveToTopOfPrioritySubqueue();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lingPai!=null)
        {
            lingPaiZhuanHua.transform.position = lingPai.transform.position;
            lingPaiZhuanHua.transform.eulerAngles = lingPai.transform.eulerAngles;
            //UI  比例
            float ux=  uiYou.transform.localPosition.x - uiZuo.transform.localPosition.x;
            float uy= uiShang.transform.localPosition.y - uiXia.transform.localPosition.y;

            float biLi_X = (lingPaiZhuanHua.transform.localPosition.x - uiZuo.transform.localPosition.x) / ux;
            float biLi_Y = (lingPaiZhuanHua.transform.localPosition.y - uiXia.transform.localPosition.y) / uy;


            //计算相机位置
            float cx = tuYou.transform.localPosition.z- tuZuo.transform.localPosition.z;
            float cy =  tuShang.transform.localPosition.x- tuXia.transform.localPosition.x ;

            xiangJi.transform.localPosition = new Vector3(tuXia.transform.localPosition.x + (cy * biLi_Y), 80, tuZuo.transform.localPosition.z + (cx * biLi_X) );
            //计算相机角度
            xiangJi.transform.localEulerAngles = new Vector3(0, lingPaiZhuanHua.transform.eulerAngles.z*-1, 0);

        }
    }
}
