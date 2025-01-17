using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 一级按钮
/// </summary>
public class YiJiAnNiu : GestureBase
{
    [Header("检测目标")]
    public GameObject muBiao;
    [Header("检测半径")]
    public float banJing=110;

    public override bool Detected()
    {

        return (muBiao.transform.position - transform.position).magnitude <= banJing;
    }

}
