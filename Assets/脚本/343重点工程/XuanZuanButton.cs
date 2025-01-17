using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 所有的旋转按钮
/// </summary>
public class XuanZuanButton : MonoBehaviour
{
    public int id = -1;
    [Header("点击事件")]
    public UnityEvent click;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /// <summary>
    /// 未选中状态
    /// </summary>
    public void WeiXuanZhong()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
    }
    /// <summary>
    /// 选中状态
    /// </summary>
    public void XuanZhong()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        click.Invoke();
    }
    /// <summary>
    /// 点击ui
    /// </summary>
    public void OnCLick_UI()
    {
        GetComponentInParent<XuanZuanButton_M>().OnCLickButton(id);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
