using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
/// <summary>
/// 开始暂停
/// </summary>
public class KaiShiZanTing_Scenes : MonoBehaviour
{
    
    public GameObject kaiShiButton;

    public GameObject zhanTingButton;


    public VideoPlayer[] videos;
    public void OnEnable()
    {
        kaiShiButton.SetActive(false);
        zhanTingButton.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public VideoPlayer videoPlayer_JiLu;
    /// <summary>
    /// 点击暂停
    /// </summary>
    public void OnCLickZhanTing()
    {
        kaiShiButton.SetActive(true);
        zhanTingButton.SetActive(false);
        Time.timeScale = 0;
        videoPlayer_JiLu = null;
        foreach (var item in videos)
        {
            if (item.isPlaying)
            {
                videoPlayer_JiLu = item;
                videoPlayer_JiLu.Pause();
            }
        }
    }
    /// <summary>
    /// 点击开始
    /// </summary>
    public void OnCLickKaiShi()
    {
        kaiShiButton.SetActive(false);
        zhanTingButton.SetActive(true);
        Time.timeScale = 1;
        if (videoPlayer_JiLu!=null)
        {
            videoPlayer_JiLu.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
