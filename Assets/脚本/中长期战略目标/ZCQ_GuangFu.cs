using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 中长期 光伏
/// </summary>
public class ZCQ_GuangFu : MonoBehaviour
{
    [Header("提示图")]
    public GameObject[] tiShiTu;
    [Header("按钮")]
    public GameObject[] button;
    [Header("按钮选中")]
    public GameObject[] buttonXuanZhong;

    public GuangFu_DaPing daPing;
    /// <summary>
    /// 点击
    /// </summary>
    /// <param name="data"></param>
    public void OnClick(int data)
    {
        for (int i = 0; i < tiShiTu.Length; i++)
        {
            tiShiTu[i].SetActive(data == i);
            button[i].SetActive(data != i);
            buttonXuanZhong[i].SetActive(data == i);
        }
        daPing.OnClick(data);
    }
    public void OnEnable()
    {
        OnClick(0);
        daPing.StartGame();
    }

    public void OnDisable()
    {
        daPing.EntGame();
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    /// <summary>
    /// 开始
    /// </summary>
    public void StartGame()
    {

    }


    /// <summary>
    /// 结束
    /// </summary>
    public void EntGame()
    {

    }

    public void Update()
    {
        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    OnClick(0);
        //}
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    OnClick(1);
        //}
    }
}
