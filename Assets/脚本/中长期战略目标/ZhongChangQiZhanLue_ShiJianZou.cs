using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 中长期战略时间轴
/// </summary>
public class ZhongChangQiZhanLue_ShiJianZou : MonoBehaviour
{
    [Header("时间ID")]
    public int shiJianID;
    [Header("文字")]
    public GameObject[] wenZhi;
   // [Header("时间按钮")]
    //public GameObject[] buttons;
    [Header("大屏时间轴")]
    public ShiJianZou shiJianZou;

    public void OnEnable()
    {
        ChuShi();
    }
    /// <summary>
    /// 初始化
    /// </summary>
    public void ChuShi()
    {

        //大屏切换第一个时间轴  第一个点
        shiJianZou.ChuShiHua();
        //切换到第一个
        OnCLick_ShiJian(0);
    }

    public void OnDisable()
    {
        shiJianZou.EntGame();
    }

    /// <summary>
    /// 点击时间
    /// </summary>
    /// <param name="data"></param>
    public void OnCLick_ShiJian(int data)
    {
        shiJianZou.OnClick_NianFen(data);
        shiJianID = data;
        for (int i = 0; i < wenZhi.Length; i++)
        {
            wenZhi[i].GetComponent<Animator>().SetBool("isXuan", i == data);
        }
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
