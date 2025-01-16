using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 模拟操作
/// </summary>
public class MoLiCaoZuo : MonoBehaviour
{
    public GameObject ui0;

    public GameObject ui1;


    float z0 = 0;
    float z1 = 1;



    public GameObject ui0_TiShi;

    public GameObject ui1_TiShi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            ui0.SetActive(!ui0.activeInHierarchy);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ui1.SetActive(!ui1.activeInHierarchy);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            z0 += Time.deltaTime * 90;
            if (z0 > 360)
            {
                z0 -= 360;
            }
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            z0 -= Time.deltaTime * 90;
            if (z0 < 0)
            {
                z0 += 360;
            }
        }
        ui0.transform.localEulerAngles = new Vector3(0, 0, z0);




        //第二个令牌

        if (Input.GetKey(KeyCode.Q))
        {
            z1 += Time.deltaTime * 90;
            if (z1 > 360)
            {
                z1 -= 360;
            }

        }
        if (Input.GetKey(KeyCode.E))
        {
            z1 -= Time.deltaTime * 90;
            if (z1 < 0)
            {
                z1 += 360;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            ui1.transform.localPosition += new Vector3(0, 1, 0) * Time.deltaTime * 200;

        }
        if (Input.GetKey(KeyCode.S))
        {
            ui1.transform.localPosition += new Vector3(0,-1, 0) * Time.deltaTime * 200;
        }

        if (Input.GetKey(KeyCode.A))
        {
            ui1.transform.localPosition += new Vector3(-1, 0, 0) * Time.deltaTime * 200;

        }
        if (Input.GetKey(KeyCode.D))
        {
            ui1.transform.localPosition += new Vector3(1, 0, 0) * Time.deltaTime * 200;
        }

        ui1.transform.localEulerAngles = new Vector3(0, 0, z1);


        ui0_TiShi.transform.eulerAngles = ui0.transform.eulerAngles;
        ui0_TiShi.transform.position = ui0.transform.position;
        ui0_TiShi.SetActive(ui0.activeInHierarchy);

        ui1_TiShi.transform.eulerAngles = ui1.transform.eulerAngles;
        ui1_TiShi.transform.position = ui1.transform.position;
        ui1_TiShi.SetActive(ui1.activeInHierarchy);
    }
}
