using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// 令牌按钮
/// </summary>
public class lingPaiButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [Header("进入")]
    public UnityEvent jingRu;
    [Header("退出")]
    public UnityEvent tuiChu;
    [Header("目标")]
    public GameObject muBiao;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "lingPai")
        {
           // if (muBiao==null)
            //{
                muBiao = collision.gameObject;
                jingRu.Invoke();
           // }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "lingPai")
        {
            Debug.Log($"OnTriggerExit2D...: {collision.tag}");
            // if (muBiao== collision.gameObject)
            // {
            muBiao = null;
            tuiChu.Invoke();
           // }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
