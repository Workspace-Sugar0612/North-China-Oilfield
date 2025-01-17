using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 同步令牌
/// </summary>
public class TongBu_BiaoQian : GestureBase
{
    [Header("令牌")]
    public GameObject lingPai;
    [Header("目标对象")]
    public GameObject muBiao;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<GestureDetection>().OnGestureStart.AddListener(XianShi);
        GetComponent<GestureDetection>().OnGestureStay.AddListener(YunDong);
        GetComponent<GestureDetection>().OnGestureEnd.AddListener(YingChang);
    }
    [Header("显示")]
    public bool isXianShi;
    public override bool Detected()
    {
        isXianShi = lingPai.activeInHierarchy;
        return lingPai.activeInHierarchy;
    }
    /// <summary>
    /// 显示
    /// </summary>
    public void XianShi()
    {
        //print("LLLLLLLLLLLLLLLL" + lingPai.name);
        muBiao.transform.position = lingPai.transform.position;
        muBiao.transform.eulerAngles = lingPai.transform.eulerAngles;
        muBiao.SetActive(true);
    }

    /// <summary>
    /// 运动
    /// </summary>
    public void YunDong()
    {
        muBiao.transform.position = lingPai.transform.position;
        muBiao.transform.eulerAngles = lingPai.transform.eulerAngles;
    }
    /// <summary>
    /// 隐藏
    /// </summary>
    public void YingChang()
    {
        print("YYYYYYYYYYY" + lingPai.name);
        muBiao.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
