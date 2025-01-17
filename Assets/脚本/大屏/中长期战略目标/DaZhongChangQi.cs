using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 大屏中长期
/// </summary>
public class DaZhongChangQi : MonoBehaviour
{

    [Header("界面显示")]
    public GameObject jieMian;
    [Header("所有标题")]
    public GameObject[] biaoTis;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChuShi()
    {
        jieMian.SetActive(true);
    }
    public void EntGame()
    {
        jieMian.SetActive(false);
    }

    public void OnClick(int data)
    {
        for (int i = 0; i < biaoTis.Length; i++)
        {
            biaoTis[i].SetActive(data == i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
