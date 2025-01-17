using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
/// <summary>
/// 视频播放
/// </summary>
public class Video_Url : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public GameObject[] quanPings;
    public void OnEnable()
    {
        videoPlayer.url = Application.streamingAssetsPath + "/宣传片.mp4";
        videoPlayer.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        SuoXiao();
    }
    /// <summary>
    /// 重播
    /// </summary>
    public void ChongBo()
    {
        videoPlayer.Stop();
        videoPlayer.Play();
    }
    /// <summary>
    /// 全屏
    /// </summary>
    public void QuanPing()
    {
        foreach (var item in quanPings)
        {
            if (item!=null)
            {
                item.SetActive(true);
            }
        }
    }
    /// <summary>
    /// 缩小
    /// </summary>
    public void SuoXiao()
    {
        foreach (var item in quanPings)
        {
            if (item != null)
            {
                item.SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
