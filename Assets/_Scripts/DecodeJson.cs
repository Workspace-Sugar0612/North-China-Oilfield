using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using UnityEngine.UI;
public class DecodeJson : MonoBehaviour
{



    public List<Transform> modelsList;
    // Use this for initialization
    void Start()
    {
        InitList();
    }

    // Update is called once per frame
    void Update()
    {
        GetModelsInfo();

    }

    public List<ModelInfo> modelInfosList = new List<ModelInfo>();

    public struct ModelInfo
    {
        public int modelId;
        public bool isAlive;
        public float posX;
        public float posY;
        public float angle;
    }

    public void InitList()
    {
        for (int i = 0; i < 5; i++)
        {
            ModelInfo modelInfo = new ModelInfo();
            modelInfosList.Add(modelInfo);
        }
    }

    //解析Json
    public void GetModelsInfo()
    {
        if (UDPReceive.instance.recdata != null)
        {
            if (UDPReceive.instance.recdata.Contains("model"))
            {
                JsonData jsonData = JsonMapper.ToObject(UDPReceive.instance.recdata);

                for (int i = 0; i < jsonData.Count; i++)
                {
                    if (jsonData["model0" + i.ToString()]["isAlive"].ToString() == "True")
                    {
                        if (modelsList[i].GetComponent<RectTransform>().anchoredPosition.x.ToString() == "NaN" || modelsList[i].GetComponent<RectTransform>().anchoredPosition.y.ToString() == "NaN" || modelsList[i].GetComponent<RectTransform>().localRotation.z.ToString() == "NaN")
                        {
                            modelsList[i].GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                            modelsList[i].GetComponent<RectTransform>().localEulerAngles = Vector3.zero;
                        }

                        modelsList[i].gameObject.SetActive(true);

                        if (jsonData["model0" + i.ToString()]["posX"].ToString().Contains("Infinity"))
                            continue;

                        if (jsonData["model0" + i.ToString()]["posY"].ToString().Contains("Infinity"))
                            continue;

                        if (jsonData["model0" + i.ToString()]["angle"].ToString().Contains("Infinity"))
                            continue;


                        //Debug.Log("第" + i.ToString() + "个模块是否被激活" + ":" + jsonData["model0" + i.ToString()]["isAlive"]);
                        //Debug.Log("第" + i.ToString() + "个模块的X轴位置" + ":" + jsonData["model0" + i.ToString()]["posX"]);
                        //Debug.Log("第" + i.ToString() + "个模块的Y轴位置" + ":" + jsonData["model0" + i.ToString()]["posY"]);
                        //Debug.Log("第" + i.ToString() + "个模块的角度" + ":" + jsonData["model0" + i.ToString()]["angle"]);
                        //Debug.Log("---------------------------------------------------------------");


                        float x = float.Parse(jsonData["model0" + i.ToString()]["posX"].ToString()) * Screen.width - Screen.width / 2;
                        float y = float.Parse(jsonData["model0" + i.ToString()]["posY"].ToString()) * Screen.height - Screen.height / 2;
                        float angleZ = float.Parse(jsonData["model0" + i.ToString()]["angle"].ToString());

                        //位置赋值
                        modelsList[i].GetComponent<RectTransform>().anchoredPosition = Vector3.Lerp(modelsList[i].GetComponent<RectTransform>().anchoredPosition, new Vector2(x, y), Time.deltaTime * 10);  //最后这个乘10，可以调整，用来控制移动的平滑度
                                                                                                                                                                                                             //角度赋值
                        modelsList[i].GetComponent<RectTransform>().localRotation = Quaternion.Slerp(modelsList[i].GetComponent<RectTransform>().localRotation, Quaternion.Euler(new Vector3(0, 0, angleZ)), Time.deltaTime * 5); //最后这个乘5，可以调整，用来控制旋转的平滑度

                    }
                    else
                    {
                        modelsList[i].gameObject.SetActive(false);
                    }


                }

            }
            UDPReceive.instance.recdata = null;
        }
    }
}
