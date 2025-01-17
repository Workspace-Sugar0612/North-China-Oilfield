using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// 按钮旋转
/// </summary>
public class AnNiuXuanZuan : MonoBehaviour
{
    /// <summary>
    /// 令牌
    /// </summary>
    [Header("令牌")]
    public GameObject lingPai;
    [Header("射线原点")]
    public GameObject sheXianYuanDian;
    [Header("是否检测")]
    public bool isJianChe;

    public LayerMask LayerMask;
    /// <summary>
    /// 当前id
    /// </summary>
    public int id=-1;

    public UnityEvent jiaEvent;

    public UnityEvent jianEvent;

    [Header("是否移动")]
    public bool isMove=true;
    public void OnEnable()
    {
        id = -1;
        isJianChe = false;
        CancelInvoke();
        Invoke("StartJianChe", 0.1f);
    }
    /// <summary>
    /// 开始检测
    /// </summary>
    public void StartJianChe()
    {
        isJianChe = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lingPai==null)
        {
            return;
        }
        if (isMove)
        {
            //同步位置
            transform.position = lingPai.transform.position;
        }

        //同步旋转
        sheXianYuanDian.transform.localEulerAngles = lingPai.transform.localEulerAngles;
        //检测
        RaycastHit2D hit2D = Physics2D.Raycast(sheXianYuanDian.transform.position, sheXianYuanDian.transform.right, 10000, LayerMask);
        if (hit2D)
        {
           

            if (isJianChe)
            {
                if (id==-1)
                {
                    id = int.Parse(hit2D.transform.name);
                }
                else//判断是否需要旋转
                {
                    int dangQianID= int.Parse(hit2D.transform.name);
                    if (dangQianID!=id)//状态切换了
                    {
                        if (id==0)
                        {
                            if (dangQianID==10)
                            {
                                print("减");
                                jianEvent.Invoke();
                            }
                            else
                            {
                                print("加");
                                jiaEvent.Invoke();
                            }
                        }
                        else if (id==10)
                        {
                            if (dangQianID == 0)
                            {
                                print("加");
                                jiaEvent.Invoke();
                             
                            }
                            else
                            {
                                print("减");
                                jianEvent.Invoke();
                            }
                        }
                        else
                        {
                            if (dangQianID> id)
                            {
                                print("加");
                                jiaEvent.Invoke();
                            }
                            else
                            {
                                print("减");
                                jianEvent.Invoke();
                            }
                        }
                        id = dangQianID;
                    }
                }
            }
            else
            {
                if (hit2D.transform!=null)
                {
                    id = int.Parse(hit2D.transform.name);
                }
            }
        }
    }
}
