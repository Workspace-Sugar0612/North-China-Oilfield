using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 延迟启动碰撞器
/// </summary>
public class YanChiQiDongPengZhuang : MonoBehaviour
{
    public void OnEnable()
    {
        Invoke("JiHuo", 0.5f);
    }

    public void JiHuo()
    {
        GetComponent<CircleCollider2D>().enabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDisable()
    {
        GetComponent<CircleCollider2D>().enabled = false;
    }
}
