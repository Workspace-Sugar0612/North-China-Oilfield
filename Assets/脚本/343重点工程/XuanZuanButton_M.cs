using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 旋转按钮管理
/// </summary>
public class XuanZuanButton_M : MonoBehaviour
{
    [Header("所有需要控制的旋转按钮")]
    public XuanZuanButton[] zuanButtons;
    [Header("当前旋转的按钮")]
    public int id = -1;
    [Header("是否需要显示的时候就初始化")]
    public bool isChuShiHua;
    void Start()
    {
        for (int i = 0; i < zuanButtons.Length; i++)
        {
            zuanButtons[i].id = i;
        }
    }
    public void OnEnable()
    {
        if (isChuShiHua)
        {
            id = 0;
            ChuShiHua();
        }
     
    }
    /// <summary>
    /// 初始化数据
    /// </summary>
    public void ChuShiHua()
    {
        if (id<0)
        {
            id = 0;
        }
        foreach (var item in zuanButtons)
        {
            item.WeiXuanZhong();
        }
        zuanButtons[id].XuanZhong();
    }
    /// <summary>
    /// 点击了一个按钮
    /// </summary>
    public void OnCLickButton(int data)
    {
        id = data;
        for (int i = 0; i < zuanButtons.Length; i++)
        {
            if (i==data)
            {
                zuanButtons[i].XuanZhong();
            }
            else
            {
                zuanButtons[i].WeiXuanZhong();
            }
        }
    }
    /// <summary>
    /// 下一个
    /// </summary>
    public void XiaYiGe()
    {
        id--;
        if (id<0 )
        {
            id = zuanButtons.Length-1;
        }
        OnCLickButton(id);
    }
    /// <summary>
    /// 上一个
    /// </summary>
    public void ShangYiGe()
    {
        id++;
        if (id >= zuanButtons.Length)
        {
            id = 0;
        }
        OnCLickButton(id);
    }

    void Update()
    {
        
    }
}
