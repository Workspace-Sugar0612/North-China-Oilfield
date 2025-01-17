using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
/// <summary>
/// 播放流程
/// </summary>
public class LiuChengVideos : MonoBehaviour
{
    [Header("视频名称")]
    public string[] videoNames;
    [Header("播放进度")]
    public int jingDu;
    public VideoPlayer video_P;
    [Header("是否做离开检测")]
    public bool isLiKaiJianChe;

    public int buttonID;
    public void OnEnable()
    {
        jingDu = -1;
        BoFangXiaYiGe();
    }
    /// <summary>
    /// 播放下一个
    /// </summary>
    public void BoFangXiaYiGe()
    {
        jingDu++;
        if (jingDu >= videoNames.Length)
        {
            WanChengLiuCheng();
            return;
        }
        Debug.Log($"BoFangXiaYiGe: {jingDu}");
        video_P.url = Application.streamingAssetsPath + "/" + videoNames[jingDu] + ".mp4";
        video_P.Play();
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
    }

    public void PlayFanHui()
    {
        // Debug.Log($"FanHui: {videoNames[jingDu]}");
        jingDu = videoNames.Length - 1;
        video_P.url = Application.streamingAssetsPath + "/" + videoNames[jingDu] + ".mp4";
        video_P.Play();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (isLiKaiJianChe)
        {
            if (jingDu >= 0 && jingDu != videoNames.Length - 1)
            {
                if (!Game_M2.initialize.erJiZhangTai[buttonID])
                {
                    // BoFangXiaYiGe();
                    PlayFanHui();
                }
            }
        }
    }
}
