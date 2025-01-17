using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 线条
/// </summary>
public class XianTiao : MonoBehaviour
{
    /// <summary>
    /// 原点
    /// </summary>
    public GameObject yuanDian;
    /// <summary>
    /// 指向目标
    /// </summary>
    public GameObject muBaio;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //计算距离
        float juLi = (muBaio.transform.localPosition - yuanDian.transform.localPosition).magnitude - 250;
        //设置显示长度
        transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(juLi, 100);
        //设置方向
        transform.right = (muBaio.transform.localPosition - yuanDian.transform.localPosition);
        //设置透明度
        int geShu =(int) (juLi / 33);

        for (int i = 0; i < geShu; i++)
        {
            transform.GetChild(0).GetChild(i).GetComponent<Image>().color = new Color(1, 1, 1,0.01f+ (i/(geShu*1f)));
        }
    }
}
