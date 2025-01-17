using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 中长期战略目标
/// </summary>
public class ZhongChangQiZhanLue : MonoBehaviour
{
    [Header("右上角的按钮")]
    public lingPaiButton lingPaiButton;
    [Header("旋转按钮")]
    public AnNiuXuanZuan anNiuXuanZuan;
    [Header("旋转按钮选择")]
    public XuanZuanButton_M xuanZuanButton_M;


    [Header("各个模块的界面")]
    public GameObject[] jieMian;
    [Header("中长期大屏")]
    public DaZhongChangQi daZhongChangQi;
    /// <summary>
    /// 初始化
    /// </summary>
    public void ChuShi()
    {
        xuanZuanButton_M.id = 3;
        xuanZuanButton_M.ChuShiHua();
        //令牌
        anNiuXuanZuan.lingPai = lingPaiButton.muBiao;
        daZhongChangQi.ChuShi();
    }
    /// <summary>
    /// 结束展示
    /// </summary>
    public void EntGame()
    {
        daZhongChangQi.EntGame();
    }
    /// <summary>
    /// 切换
    /// </summary>
    /// <param name="data"></param>
    public void OnClick(int data)
    {
        foreach (var item in jieMian)
        {
            item.SetActive(false);
        }
        jieMian[data].SetActive(true);

        daZhongChangQi.OnClick(data);
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
