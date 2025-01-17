using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 四项
/// </summary>
public class SiXiang : MonoBehaviour
{
    [Header("标题")]
    public GameObject[] biaoTis;
    [Header("界面")]
    public GameObject[] jieMian;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClcik(int data)
    {
        foreach (var item in biaoTis)
        {
            item.SetActive(false);
        }
        foreach (var item in jieMian)
        {
            item.SetActive(false);
        }
        biaoTis[data].SetActive(true);
        jieMian[data].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
