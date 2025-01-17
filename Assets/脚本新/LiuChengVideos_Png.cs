using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
/// <summary>
/// 播放流程带图片
/// </summary>
public class LiuChengVideos_Png : MonoBehaviour
{
    [Header("按钮ID")]
    public int buttonID;
    [Header("图片名")]
    public string imagePNG;

    [Header("视频名称")]
    public string[] videoNames;

    [Header("图片显示")]
    public RawImage rawImagePng;

    [Header("播放进度")]
    public int jingDu;
    public VideoPlayer video_P;
    public void OnEnable()
    {
        jingDu = -1;
        transform.GetChild(0).gameObject.SetActive(false);
        BoFangXiaYiGe();
    }

    /// <summary>
    /// 播放下一个
    /// </summary>
    public void BoFangXiaYiGe()
    {
        Debug.Log($"BoFangXiaYiGe: {jingDu}");
        jingDu++;
        if (jingDu >= videoNames.Length)
        {
            WanChengLiuCheng();
            return;
        }
        if (videoNames[jingDu] == "")//播放图片  等待操作
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            video_P.url = Application.streamingAssetsPath + "/" + videoNames[jingDu] + ".mp4";
            video_P.Play();
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// 完成流程
    /// </summary>
    public void WanChengLiuCheng()
    {
        gameObject.SetActive(false);//关闭页面
        Game_M2.initialize.JieShuBoDang();
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VideoEvent>().videoEnt.AddListener(BoFangXiaYiGe);
        StartCoroutine(StartJiaZai());
    }

    public IEnumerator StartJiaZai()
    {

        WWW www7 = new WWW(Application.streamingAssetsPath + "/" + imagePNG + ".png");
        // print(Application.streamingAssetsPath + "/领域/背景/" + item.name + "背景.jpg");
        yield return www7;
        if (www7 != null && string.IsNullOrEmpty(www7.error))
        {
            //获取Texture
            Texture texture = www7.texture;
            rawImagePng.texture = texture;
        }
    }
    /// <summary>
    /// 播放返回视频
    /// </summary>
    public void PlayFanHui()
    {
        Debug.Log("Play Fan Hui....");
        jingDu = videoNames.Length - 1;
        video_P.url = Application.streamingAssetsPath + "/" + videoNames[jingDu] + ".mp4";
        video_P.Play();
        transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"JingDu: {jingDu}, videoNames.Length - 1: {videoNames.Length - 1}");
        if (jingDu >= 0 && jingDu != videoNames.Length - 1)
        {
            if (!Game_M2.initialize.erJiZhangTai[buttonID])
            {
                //  BoFangXiaYiGe();
                PlayFanHui();
            }
        }
    }
}
