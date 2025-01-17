using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Da343_SanDa : MonoBehaviour
{
    [Header("标题")]
    public GameObject[] biaoTis;
    [Header("右侧选中")]
    public GameObject[] youChes_Xuan;
    [Header("右侧未选中")]
    public GameObject[] youChes_WeiXuan;
    [Header("弹窗")]
    public GameObject[] tanChuangs;

    [Header("特效")]
    public GameObject[] teXiao;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void XianShi(int data)
    {
        foreach (var item in biaoTis)
        {
            item.SetActive(false);
        }
        for (int i = 0; i < youChes_Xuan.Length; i++)
        {
            youChes_Xuan[i].SetActive(i == data);
        }
        for (int i = 0; i < youChes_WeiXuan.Length; i++)
        {
            youChes_WeiXuan[i].SetActive(i != data);
        }
        foreach (var item in tanChuangs)
        {
            item.SetActive(false);
        }
        foreach (var item in teXiao)
        {
            item.SetActive(false);
        }
        biaoTis[data].SetActive(true);
        
        tanChuangs[data].SetActive(true);
        teXiao[data].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
