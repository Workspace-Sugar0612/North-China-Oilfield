using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// 浮动
/// </summary>
public class FuDong : MonoBehaviour
{
    /// <summary>
    /// 半径
    /// </summary>
    public float banJing;

    public float s = 5;

  // public Vector3 fangXiang;
    public void OnEnable()
    {
        CancelInvoke();

        SuiJi();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SuiJi()
    {
        print("suiji");
        float x = Random.Range(banJing * -1, banJing);
        float y = Random.Range(banJing * -1, banJing);
        float z = Random.Range(banJing * -1, banJing);
        Vector3 vv = new Vector3(x, y, z);
        //计算延迟时间
        float ti = (transform.localPosition- vv).magnitude / s; 
        //   fangXiang = (transform.localPosition - vv).normalized;
        transform.DOLocalMove(vv, ti);
        CancelInvoke();
        Invoke("SuiJi", ti);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.localPosition += fangXiang * Time.deltaTime * s;
    }
}
