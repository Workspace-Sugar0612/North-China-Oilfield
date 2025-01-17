using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PeiZhi_M : MonoBehaviour
{

    public static PeiZhi_M initialize;
    private void Awake()
    {
        initialize = this;
    }

    public PeiZhi[] peiZhis;
    // Start is called before the first frame update
    void Start()
    {
            SanBuZhou sanBuZhou;

   ShiSiWu shiSiWu;

    GuiHua guiHua;

        sanBuZhou= JsonConvert.DeserializeObject<SanBuZhou>(File.ReadAllText(Application.streamingAssetsPath+ "/三步走.txt"));
        shiSiWu = JsonConvert.DeserializeObject<ShiSiWu>(File.ReadAllText(Application.streamingAssetsPath + "/十四五.txt"));
        guiHua = JsonConvert.DeserializeObject<GuiHua>(File.ReadAllText(Application.streamingAssetsPath + "/规划.txt"));
        foreach (var item in peiZhis)
        {
            item.sanBuZhou = sanBuZhou;
            item.shiSiWu = shiSiWu;
            item.guiHua = guiHua;
            item.StartUpDate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
