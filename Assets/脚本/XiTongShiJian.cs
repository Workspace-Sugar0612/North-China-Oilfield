using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XiTongShiJian : MonoBehaviour
{
    /// <summary>
    /// 显示时间
    /// </summary>
    public Text text_ShiJian;
    /// <summary>
    /// 显示日期
    /// </summary>
    public Text text_RiQi;
    /// <summary>
    /// 显示星期
    /// </summary>
    public Text text_xinQi;

    string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_ShiJian.text= DateTime.Now.ToString("HH:mm:ss");

        text_RiQi.text = DateTime.Now.ToString("yyyy-MM-dd");

        text_xinQi.text= Day[(int)(DateTime.Now.DayOfWeek)];
    }
}
