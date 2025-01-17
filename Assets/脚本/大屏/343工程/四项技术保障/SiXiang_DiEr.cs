using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 地热
/// </summary>
public class SiXiang_DiEr : MonoBehaviour
{
    /// <summary>
    /// 地图模型
    /// </summary>
    public GameObject[] diTuModel;
    /// <summary>
    /// 热力图
    /// </summary>
    public GameObject reLiTu;

    /// <summary>
    /// 选中按钮
    /// </summary>
    public GameObject[] xuanZhong;
    /// <summary>
    /// 未选中按钮
    /// </summary>
    public GameObject[] weiXuanZhong;

    /// <summary>
    /// 弹窗
    /// </summary>
    public GameObject[] tanChuang;
    [Header("地热模型")]
    public GameObject[] mdels;

    [Header("地热视角")]
    public CinemachineVirtualCameraBase vcam_diEr;

    int id = 0;

    public void OnEnable()
    {
        foreach (var item in diTuModel)
        {
            item.SetActive(false);
        }
        reLiTu.SetActive(true);

        id = -1;
        CancelInvoke();
        InvokeRepeating("XiaYiGe", 0, 5);
        //切换视角
        vcam_diEr.MoveToTopOfPrioritySubqueue();
    }

    public void XiaYiGe()
    {
        id++;
        if (id>= tanChuang.Length)
        {
            id = 0;
        }
        for (int i = 0; i < xuanZhong.Length; i++)
        {
            xuanZhong[i].SetActive(i == id);
            weiXuanZhong[i].SetActive(i != id);
            tanChuang[i].SetActive(i == id);
            mdels[i].SetActive(i == id);
        }
    }

    public void OnDisable()
    {
        CancelInvoke();
        foreach (var item in diTuModel)
        {
            item.SetActive(true);
        }
        reLiTu.SetActive(false);
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
