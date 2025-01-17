using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 三大初始化
/// </summary>
public class SanDaChuShiHua : MonoBehaviour
{
    /// <summary>
    /// 需要初始化的数据
    /// </summary>
    public GameObject[] chuShiData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        
    }

    public void OnDisable()
    {
        foreach (var item in chuShiData)
        {
            item.SetActive(false);
        }
    }
}
