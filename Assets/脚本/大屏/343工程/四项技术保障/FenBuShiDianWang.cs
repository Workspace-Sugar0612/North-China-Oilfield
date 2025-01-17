using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 触摸屏  分布式电网
/// </summary>
public class FenBuShiDianWang : MonoBehaviour
{

    [Header("所有需要隐藏的沙盘模型")]
    public GameObject[] shaPan;
    [Header("电网模型")]
    public GameObject[] danWang;

    [Header("分布式电网视角")]
    public CinemachineVirtualCameraBase vcam_FenBu;


    public void OnEnable()
    {
        //切换视角
        vcam_FenBu.MoveToTopOfPrioritySubqueue();
        foreach (var item in shaPan)
        {
            item.SetActive(false);
        }

        foreach (var item in danWang)
        {
            item.SetActive(true);
        }
    }


    public void OnDisable()
    {
        foreach (var item in shaPan)
        {
            item.SetActive(true);
        }

        foreach (var item in danWang)
        {
            item.SetActive(false);
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
