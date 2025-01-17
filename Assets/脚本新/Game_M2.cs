using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 游戏管理员
/// </summary>
public class Game_M2 : MonoBehaviour
{
    public static Game_M2 initialize;
    private void Awake()
    {
        initialize = this;
    }
    [Header("是否启动")]
    public bool isQiDong;

    [Header("二级状态")]
    public bool[] erJiZhangTai;
    [Header("视频界面")]
    public GameObject[] videoUI;
    [Header("按钮选中状态")]
    public GameObject[] buttonXuans;
    [Header("待机视频界面")]
    public GameObject daiJiUI;
    [Header("开场视频界面")]
    public GameObject kaiChangUI;
    [Header("开场视频界面图片")]
    public GameObject kaiChangUI_Image;
    [Header("是否正在播放")]
    public bool isPlay;
    [Header("当前播放的ID")]
    public int id;
    [Header("用户操作ID")]
    public int idCaoZuo;
    // Start is called before the first frame update
    void Start()
    {
        id = -2;
        StartCoroutine(StartJiaZai());
    }
    public IEnumerator StartJiaZai()
    {

        WWW www7 = new WWW(Application.streamingAssetsPath + "/静止帧.png");
        // print(Application.streamingAssetsPath + "/领域/背景/" + item.name + "背景.jpg");
        yield return www7;
        if (www7 != null && string.IsNullOrEmpty(www7.error))
        {
            //获取Texture
            Texture texture = www7.texture;
            kaiChangUI_Image.GetComponent<RawImage>().texture = texture;

        }


    }
    /// <summary>
    /// 检测状态
    /// </summary>
    public void JianChe()
    {
        if (isPlay)//正在播放视频就直接返回
            return;

        if (isQiDong)//启动区域有令牌
        {
            //历史播放的ID和当前操作的ID相同时不进行播放
            if (id == idCaoZuo){}
            else
            {
                id = idCaoZuo;
                if (id == -1) { PlayKaiChang(); } //播放开场 
                else
                {
                    if (id >= 0 && id < videoUI.Length)
                    {
                        videoUI[id].SetActive(true);
                        daiJiUI.SetActive(false);
                        isPlay = true;
                    }
                }
            }
        }
        else//启动区域没有令牌
        {
            //播放待机视频
            id = -2;
            idCaoZuo = -2;
            daiJiUI.SetActive(true);
            kaiChangUI.SetActive(false);
            kaiChangUI_Image.SetActive(false);
            foreach (var item in videoUI)
            {
                item.SetActive(false);
            }
            isPlay = false;
        }

    }

    /// <summary>
    /// 结束播放视频
    /// </summary>
    public void JieShuBoDang()
    {
        isPlay = false;
        JianChe();
    }

    /// <summary>
    /// 设置待机的状态
    /// </summary>
    public void SetDaiJi(bool data)
    {
        Debug.Log("SetDaiJi...");
        isQiDong = data;
        if (isQiDong == true && !isPlay)
        {
            idCaoZuo = -1;
        }
        if (!isQiDong)
        {
            for (int i = 0; i < erJiZhangTai.Length; i++)
            {
                erJiZhangTai[i] = false;
            }
        }
        JianChe();
    }

    /// <summary>
    /// 播放开场
    /// </summary>
    public void PlayKaiChang()
    {
        isPlay = true;
        kaiChangUI.SetActive(true);
        kaiChangUI_Image.SetActive(false);
        daiJiUI.SetActive(false);
    }

    /// <summary>
    /// 结束开场播放
    /// </summary>
    public void EntKaiChangPlay()
    {
        isPlay = false;
        kaiChangUI.SetActive(false);
        kaiChangUI_Image.SetActive(true);
        JianChe();
    }

    /// <summary>
    /// 开启其他的页面
    /// </summary>
    /// <param name="data"></param>
    public void KaiQiTa(int data)
    {
        for (int i = 0; i < erJiZhangTai.Length; i++)
        {
            erJiZhangTai[i] = false;
        }
        erJiZhangTai[data] = true;
  
        idCaoZuo = data;
        JianChe();
    }

    /// <summary>
    /// 关闭其他页面
    /// </summary>
    /// <param name="data"></param>
    public void GuanQiTa(int data)
    {
        Debug.Log($"GuanQiTa: {data}");
        erJiZhangTai[data] = false;

        for (int i = 0; i < erJiZhangTai.Length; i++)
        {
            if (erJiZhangTai[i])
            {
                idCaoZuo = i;
                return;
            }
        }
        idCaoZuo = -2;
        JianChe();
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < buttonXuans.Length; i++)
        {
            if (buttonXuans[i] != null)
            {
                buttonXuans[i].SetActive(erJiZhangTai[i]);
            }
        }
    }
}
