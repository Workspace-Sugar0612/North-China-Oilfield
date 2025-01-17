using ChartAndGraph;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 配置数据
/// </summary>
public class PeiZhi : MonoBehaviour
{
    public SanBuZhou sanBuZhou;

    public ShiSiWu shiSiWu;

    public GuiHua guiHua;

    [Header("三步骤 标题")]
    public Text san_BiaoTi;
    [Header("三步骤 目标")]
    public Text san_muBiao;
    [Header("三步骤  介绍")]
    public Text san_JieShao;
    [Header("三步骤  数据显示1")]
    public Text[] san_shuJu_1;
    [Header("三步骤  数据显示2")]
    public Text[] san_shuJu_2;
    [Header("三步骤  数据显示3")]
    public Text[] san_shuJu_3;
    [Header("三步骤  数据显示4")]
    public Text[] san_shuJu_4;
    [Header("三步骤  图表")]
    public CanvasBarChart canvasBarChart;



    [Header("十四五 标题")]
    public Text shi_BiaoTi;
    [Header("十四五 标题二级")]
    public Text shi_BiaoTiEr;
    [Header("十四五 目标")]
    public Text shi_muBiao;
    [Header("十四五 介绍")]
    public Text shi_JieShao;
    [Header("十四五  数据显示1")]
    public Text[] shi_shuJu_1;
    [Header("十四五  数据显示2")]
    public Text[] shi_shuJu_2;
    [Header("十四五  数据显示3")]
    public Text[] shi_shuJu_3;
    [Header("十四五  数据显示4")]
    public Text[] shi_shuJu_4;


    [Header("规划 标题")]
    public Text guiHua_BiaoTi;
    [Header("规划 目标")]
    public Text guiHua_muBiao;
    [Header("规划 地热总")]
    public Text guiHua_erZhong;
    [Header("规划 地热数据")]
    public GameObject[] guiHua_erShuJu;
    [Header("规划 地热图表")]
    public WorldSpacePieChart pieChart_Er;
    [Header("规划 风光总")]
    public Text guiHua_fengZhong;
    [Header("规划 风光数据")]
    public GameObject[] guiHua_fengShuJu;
    [Header("规划 风光图表")]
    public CanvasPieChart pieChart_feng;
    [Header("规划 CCUS")]
    public Text guiHua_ccusZhong;
    [Header("规划 CCUS数据")]
    public GameObject[] guiHua_ccusShuJu;
    [Header("规划 CCUS图表")]
    public WorldSpacePieChart pieChart_ccus;

    // Start is called before the first frame update
  public  void StartUpDate()
    {
        //  JsonConvert.SerializeObject   JsonConvert.DeserializeObject<T>(a); 
        //string ss = JsonConvert.SerializeObject(guiHua);
        //print(ss);

        //跟新三步骤数据
        san_BiaoTi.text = sanBuZhou.biaoTi;
        san_muBiao.text = sanBuZhou.muBiao;
        san_JieShao.text = sanBuZhou.jieShao;
        san_shuJu_1[0].text = sanBuZhou.shuJu_shang_1;
        san_shuJu_1[1].text = sanBuZhou.shuJu_zhong_1;
        san_shuJu_1[2].text = sanBuZhou.shuJu_xia_1;

        san_shuJu_2[0].text = sanBuZhou.shuJu_shang_2;
        san_shuJu_2[1].text = sanBuZhou.shuJu_zhong_2;
        san_shuJu_2[2].text = sanBuZhou.shuJu_xia_2;

        san_shuJu_3[0].text = sanBuZhou.shuJu_shang_3;
        san_shuJu_3[1].text = sanBuZhou.shuJu_zhong_3;
        san_shuJu_3[2].text = sanBuZhou.shuJu_xia_3;

        san_shuJu_4[0].text = sanBuZhou.shuJu_shang_4;
        san_shuJu_4[1].text = sanBuZhou.shuJu_zhong_4;
        san_shuJu_4[2].text = sanBuZhou.shuJu_xia_4;
        canvasBarChart.DataSource.SetValue("新能源", "2025年", sanBuZhou.xin[0]);
        canvasBarChart.DataSource.SetValue("新能源", "2030年", sanBuZhou.xin[1]);
        canvasBarChart.DataSource.SetValue("新能源", "2035年", sanBuZhou.xin[2]);
        canvasBarChart.DataSource.SetValue("新能源", "2050年", sanBuZhou.xin[3]);

        canvasBarChart.DataSource.SetValue("天然气", "2025年", sanBuZhou.tian[0]);
        canvasBarChart.DataSource.SetValue("天然气", "2030年", sanBuZhou.tian[1]);
        canvasBarChart.DataSource.SetValue("天然气", "2035年", sanBuZhou.tian[2]);
        canvasBarChart.DataSource.SetValue("天然气", "2050年", sanBuZhou.tian[3]);

        canvasBarChart.DataSource.SetValue("原油", "2025年", sanBuZhou.yuan[0]);
        canvasBarChart.DataSource.SetValue("原油", "2030年", sanBuZhou.yuan[1]);
        canvasBarChart.DataSource.SetValue("原油", "2035年", sanBuZhou.yuan[2]);
        canvasBarChart.DataSource.SetValue("原油", "2050年", sanBuZhou.yuan[3]);


        //跟新十四五数据
        shi_BiaoTi.text = shiSiWu.biaoTi;
        shi_BiaoTiEr.text = shiSiWu.biaoTi_xia;
        shi_muBiao.text = shiSiWu.muBiao;
        shi_JieShao.text = shiSiWu.jieShao;
        shi_shuJu_1[0].text = shiSiWu.shuJu_shang_1;
        shi_shuJu_1[1].text = shiSiWu.shuJu_xia_1;

        shi_shuJu_2[0].text = shiSiWu.shuJu_shang_2;
        shi_shuJu_2[1].text = shiSiWu.shuJu_xia_2;

        shi_shuJu_3[0].text = shiSiWu.shuJu_shang_3;
        shi_shuJu_3[1].text = shiSiWu.shuJu_xia_3;

        shi_shuJu_4[0].text = shiSiWu.shuJu_shang_4;
        shi_shuJu_4[1].text = shiSiWu.shuJu_xia_4;


        //跟新规划
        guiHua_BiaoTi.text = guiHua.biaoTi;
        guiHua_muBiao.text = guiHua.muBiao;
           //地热
        guiHua_erZhong.text = guiHua.er_Zhong;
        guiHua_erShuJu[0].transform.GetChild(0).GetComponent<Text>().text = guiHua.er_name[0];
        guiHua_erShuJu[0].transform.GetChild(1).GetComponent<Text>().text = guiHua.er_data[0].ToString();

        guiHua_erShuJu[1].transform.GetChild(0).GetComponent<Text>().text = guiHua.er_name[1];
        guiHua_erShuJu[1].transform.GetChild(1).GetComponent<Text>().text = guiHua.er_data[1].ToString();

        guiHua_erShuJu[2].transform.GetChild(0).GetComponent<Text>().text = guiHua.er_name[2];
        guiHua_erShuJu[2].transform.GetChild(1).GetComponent<Text>().text = guiHua.er_data[2].ToString();

        guiHua_erShuJu[3].transform.GetChild(0).GetComponent<Text>().text = guiHua.er_name[3];
        guiHua_erShuJu[3].transform.GetChild(1).GetComponent<Text>().text = guiHua.er_data[3].ToString();

        guiHua_erShuJu[4].transform.GetChild(0).GetComponent<Text>().text = guiHua.er_name[4];
        guiHua_erShuJu[4].transform.GetChild(1).GetComponent<Text>().text = guiHua.er_data[4].ToString();
        pieChart_Er.DataSource.SetValue("1", guiHua.er_data[0]);
        pieChart_Er.DataSource.SetValue("2", guiHua.er_data[1]);
        pieChart_Er.DataSource.SetValue("3", guiHua.er_data[2]);
        pieChart_Er.DataSource.SetValue("4", guiHua.er_data[3]);
        pieChart_Er.DataSource.SetValue("5", guiHua.er_data[4]);
        //f风光
        guiHua_fengZhong.text = guiHua.er_Zhong;
        guiHua_fengShuJu[0].transform.GetChild(0).GetComponent<Text>().text = guiHua.feng_name[0];
        guiHua_fengShuJu[0].transform.GetChild(1).GetComponent<Text>().text = guiHua.feng_data[0].ToString();

        guiHua_fengShuJu[1].transform.GetChild(0).GetComponent<Text>().text = guiHua.feng_name[1];
        guiHua_fengShuJu[1].transform.GetChild(1).GetComponent<Text>().text = guiHua.feng_data[1].ToString();

        guiHua_fengShuJu[2].transform.GetChild(0).GetComponent<Text>().text = guiHua.feng_name[2];
        guiHua_fengShuJu[2].transform.GetChild(1).GetComponent<Text>().text = guiHua.feng_data[2].ToString();

        pieChart_feng.DataSource.SetValue("1", guiHua.feng_data[0]);
        pieChart_feng.DataSource.SetValue("2", guiHua.feng_data[1]);
        pieChart_feng.DataSource.SetValue("3", guiHua.feng_data[2]);
        //ccus
        guiHua_ccusZhong.text = guiHua.ccus_Zhong;
        guiHua_ccusShuJu[0].transform.GetChild(0).GetComponent<Text>().text = guiHua.ccus_name[0];
        guiHua_ccusShuJu[0].transform.GetChild(1).GetComponent<Text>().text = guiHua.ccus_data[0].ToString();

        guiHua_ccusShuJu[1].transform.GetChild(0).GetComponent<Text>().text = guiHua.ccus_name[1];
        guiHua_ccusShuJu[1].transform.GetChild(1).GetComponent<Text>().text = guiHua.ccus_data[1].ToString();

        guiHua_ccusShuJu[2].transform.GetChild(0).GetComponent<Text>().text = guiHua.ccus_name[2];
        guiHua_ccusShuJu[2].transform.GetChild(1).GetComponent<Text>().text = guiHua.ccus_data[2].ToString();

        guiHua_ccusShuJu[3].transform.GetChild(0).GetComponent<Text>().text = guiHua.ccus_name[3];
        guiHua_ccusShuJu[3].transform.GetChild(1).GetComponent<Text>().text = guiHua.ccus_data[3].ToString();

        pieChart_ccus.DataSource.SetValue("1", guiHua.ccus_data[0]);
        pieChart_ccus.DataSource.SetValue("2", guiHua.ccus_data[1]);
        pieChart_ccus.DataSource.SetValue("3", guiHua.ccus_data[2]);
        pieChart_ccus.DataSource.SetValue("4", guiHua.ccus_data[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/// <summary>
/// 中石油“三步走”
/// </summary>
[System.Serializable]
public class SanBuZhou
{
    /// <summary>
    /// 标题
    /// </summary>
    public string biaoTi;
    /// <summary>
    /// 目标
    /// </summary>
    public string muBiao;
    /// <summary>
    /// 介绍
    /// </summary>
    public string jieShao;

    /// <summary>
    /// 标题下面数据上 1
    /// </summary>
    public string shuJu_shang_1;
    /// <summary>
    /// 标题下面数据中  1
    /// </summary>
    public string shuJu_zhong_1;
    /// <summary>
    /// 标题下面数据下  1
    /// </summary>
    public string shuJu_xia_1;

    /// <summary>
    /// 标题下面数据上 2
    /// </summary>
    public string shuJu_shang_2;
    /// <summary>
    /// 标题下面数据中  2
    /// </summary>
    public string shuJu_zhong_2;
    /// <summary>
    /// 标题下面数据下  2
    /// </summary>
    public string shuJu_xia_2;

    /// <summary>
    /// 标题下面数据上 3
    /// </summary>
    public string shuJu_shang_3;
    /// <summary>
    /// 标题下面数据中  3
    /// </summary>
    public string shuJu_zhong_3;
    /// <summary>
    /// 标题下面数据下  3
    /// </summary>
    public string shuJu_xia_3;


    /// <summary>
    /// 标题下面数据上 4
    /// </summary>
    public string shuJu_shang_4;
    /// <summary>
    /// 标题下面数据中  4
    /// </summary>
    public string shuJu_zhong_4;
    /// <summary>
    /// 标题下面数据下  1
    /// </summary>
    public string shuJu_xia_4;
    /// <summary>
    /// 新能源 4条数据
    /// </summary>
    public float[] xin;
    /// <summary>
    /// 天然气4条数据
    /// </summary>
    public float[] tian;
    /// <summary>
    /// 原油4条数据
    /// </summary>
    public float[] yuan;

}
/// <summary>
/// 十四五
/// </summary>
[System.Serializable]
public class ShiSiWu
{
    /// <summary>
    /// 标题
    /// </summary>
    public string biaoTi;

    /// <summary>
    /// 标题二级
    /// </summary>
    public string biaoTi_xia;
    /// <summary>
    /// 目标
    /// </summary>
    public string muBiao;
    /// <summary>
    /// 介绍
    /// </summary>
    public string jieShao;


    /// <summary>
    /// 标题下面数据上 1
    /// </summary>
    public string shuJu_shang_1;

    /// <summary>
    /// 标题下面数据下  1
    /// </summary>
    public string shuJu_xia_1;

    /// <summary>
    /// 标题下面数据上 2
    /// </summary>
    public string shuJu_shang_2;

    /// <summary>
    /// 标题下面数据下  2
    /// </summary>
    public string shuJu_xia_2;

    /// <summary>
    /// 标题下面数据上 3
    /// </summary>
    public string shuJu_shang_3;

    /// <summary>
    /// 标题下面数据下  3
    /// </summary>
    public string shuJu_xia_3;


    /// <summary>
    /// 标题下面数据上 4
    /// </summary>
    public string shuJu_shang_4;

    /// <summary>
    /// 标题下面数据下  1
    /// </summary>
    public string shuJu_xia_4;
}
/// <summary>
/// 规划
/// </summary>
[System.Serializable]
public class GuiHua
{
    /// <summary>
    /// 标题
    /// </summary>
    public string biaoTi;

    /// <summary>
    /// 目标
    /// </summary>
    public string muBiao;
    /// <summary>
    /// 地热图表数据
    /// </summary>
    public float[] er_data;
    /// <summary>
    /// 地热图表数据名称
    /// </summary>
    public string[] er_name;
    /// <summary>
    /// 地热图表总量
    /// </summary>
    public string er_Zhong;


    /// <summary>
    /// 风光图表数据
    /// </summary>
    public float[] feng_data;
    /// <summary>
    /// 风光图表数据名称
    /// </summary>
    public string[] feng_name;
    /// <summary>
    /// 风光图表总量
    /// </summary>
    public string feng_Zhong;

    /// <summary>
    /// ccus图表数据
    /// </summary>
    public float[] ccus_data;
    /// <summary>
    /// ccus图表数据名称
    /// </summary>
    public string[] ccus_name;
    /// <summary>
    /// ccus图表总量
    /// </summary>
    public string ccus_Zhong;

}
