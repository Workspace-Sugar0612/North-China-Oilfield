using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// 343工程二级页面
/// </summary>
public class ErJi343 : MonoBehaviour
{
    [Header("三大按钮")]
    public GameObject sanDaButton;
    [Header("四项按钮")]
    public GameObject siXiangButton;
    [Header("三大箭头")]
    public GameObject sanJianTou;
    [Header("四项箭头")]
    public GameObject siXiangJianTou;

    [Header("上方检测区域")]
    public lingPaiButton shangJianChe;
    [Header("下方检测区域")]
    public lingPaiButton xiaJianChe;
    [Header("记录初始位置")]
    public Vector3 jiLuChuShi_Shan;

    public Vector3 jiLuChuShi_shi;


    [Header("进入三大")]
    public UnityEvent start_SanDa;

    [Header("进入四项")]
    public UnityEvent start_SiXiang;
    public void OnEnable()
    {
        //初始化
        sanDaButton.GetComponent<CanvasGroup>().alpha = 1f;
        siXiangButton.GetComponent<CanvasGroup>().alpha = 1f;
        sanJianTou.GetComponent<CanvasGroup>().alpha = 1f;
        siXiangJianTou.GetComponent<CanvasGroup>().alpha = 1f;

        sanDaButton.transform.localPosition = jiLuChuShi_Shan;
        siXiangButton.transform.localPosition = jiLuChuShi_shi;
    }

    /// <summary>
    /// 进入上方
    /// </summary>
    public void JingRu_Shang()
    {
        //正常显示
        sanDaButton.GetComponent<CanvasGroup>().alpha = 1f;
        sanJianTou.GetComponent<CanvasGroup>().alpha = 1f;
        //开始跟谁
        sanDaButton.GetComponent<AnNiuXuanZuan>().OnEnable();//初始化
        sanDaButton.GetComponent<AnNiuXuanZuan>().lingPai = shangJianChe.muBiao;
        siXiangButton.transform.localPosition = jiLuChuShi_shi;
        //调用一次初始化 切换大屏的界面

        //调用事件
        start_SanDa.Invoke();

    }
    /// <summary>
    /// 退出上方
    /// </summary>
    public void TuiChu_Shang()
    {
        //半透明
        sanDaButton.GetComponent<CanvasGroup>().alpha = 0.4f;
        sanJianTou.GetComponent<CanvasGroup>().alpha = 0.4f;
        //结束跟谁
        sanDaButton.GetComponent<AnNiuXuanZuan>().lingPai = null;
        sanDaButton.transform.localPosition = jiLuChuShi_Shan;

    }
    /// <summary>
    /// 进入下方
    /// </summary>
    public void JingRu_Xia()
    {
        //正常显示
        siXiangButton.GetComponent<CanvasGroup>().alpha = 1f;
        siXiangJianTou.GetComponent<CanvasGroup>().alpha = 1f;
        //开始跟谁
        siXiangButton.GetComponent<AnNiuXuanZuan>().OnEnable();//初始化
        siXiangButton.GetComponent<AnNiuXuanZuan>().lingPai = xiaJianChe.muBiao;
        sanDaButton.transform.localPosition = jiLuChuShi_Shan;
        //调用一次初始化 切换大屏的界面

        //调用事件
        start_SiXiang.Invoke();
    }
    /// <summary>
    /// 退出下方
    /// </summary>
    public void TuiChu_Xia()
    {
        //半透明
        siXiangButton.GetComponent<CanvasGroup>().alpha = 0.4f;
        siXiangJianTou.GetComponent<CanvasGroup>().alpha = 0.4f;
        //结束跟谁
        siXiangButton.GetComponent<AnNiuXuanZuan>().lingPai = null;
        siXiangButton.transform.localPosition = jiLuChuShi_shi;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
