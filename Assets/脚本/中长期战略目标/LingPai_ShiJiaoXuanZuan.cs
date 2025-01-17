using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 令牌旋转视角
/// </summary>
public class LingPai_ShiJiaoXuanZuan : MonoBehaviour
{


    [Header("令牌")]
    public GameObject lingPai;
    [Header("令牌转化位置")]
    public GameObject lingPaiZhuanHua;

    [Header("计算相机")]
    public GameObject xiangJi;
    [Header("令牌按钮")]
    public lingPaiButton lingPaiButton;


    /// <summary>
    /// 开始令牌
    /// </summary>
    public void StartLingPai()
    {
        lingPai = lingPaiButton.muBiao;

    }
    /// <summary>
    /// 结束令牌
    /// </summary>
    public void EntLingPai()
    {
        lingPai = null;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lingPai != null)
        {
            lingPaiZhuanHua.transform.eulerAngles = lingPai.transform.eulerAngles;
            //计算相机角度
            xiangJi.transform.localEulerAngles = new Vector3(0, lingPai.transform.eulerAngles.z * -1, 0);

        }
    }
}
