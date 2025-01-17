using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 中长期 碳捕存
/// </summary>
public class ZCQ_TanBuCun : MonoBehaviour
{


    public TanBuCun_DaPing daPing;

    public void OnEnable()
    {

        daPing.StartGame();
    }

    public void OnDisable()
    {
        daPing.EntGame();
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
}
