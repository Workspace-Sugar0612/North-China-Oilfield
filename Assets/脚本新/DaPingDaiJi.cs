using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;
/// <summary>
/// 大屏待机
/// </summary>
public class DaPingDaiJi : MonoBehaviour
{
    /// <summary>
    /// 背景
    /// </summary>
    public RawImage rawImageBeiJing;
    /// <summary>
    /// 视频
    /// </summary>
    public VideoPlayer videoPlayer;
    /// <summary>
    /// 播放ui
    /// </summary>
    public GameObject playUI;
    /// <summary>
    /// 展厅ui
    /// </summary>
    public GameObject zhanTingUI;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(StartJiaZai());
    }
    public IEnumerator StartJiaZai()
    {
        //string standbyPath = Application.streamingAssetsPath + "\\Standby.png";
        //Debug.LogError("standbyPath: =====================" + standbyPath);
        //using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(standbyPath))
        //{
        //    yield return uwr.SendWebRequest();
        //    while (true)
        //    {
        //        if (uwr.isDone)
        //        {
        //            // 使用texture
        //            Texture2D texture = DownloadHandlerTexture.GetContent(uwr);
        //            rawImageBeiJing.texture = texture;
        //            yield return null;
        //        }
        //        else
        //        {
        //            Debug.LogError("texture errorr:::::::::::::::::::::::::: " + uwr.error);
        //        }
        //    }
        //}


        WWW www7 = new WWW(Application.streamingAssetsPath + "/Standby.png");
        // print(Application.streamingAssetsPath + "/领域/背景/" + item.name + "背景.jpg");
        yield return www7;
        if (www7 != null && string.IsNullOrEmpty(www7.error))
        {
            //获取Texture
            Texture texture = www7.texture;
            rawImageBeiJing.texture = texture;
        }

        // yield return null;
    }
    /// <summary>
    /// 开始播放
    /// </summary>
    public void StartPlay()
    {
        videoPlayer.Stop();
        videoPlayer.Play();
    }
    /// <summary>
    /// 放大
    /// </summary>
    public void FangDa()
    {
        videoPlayer.GetComponent<Animator>().SetBool("isDa", true);
    }
    /// <summary>
    /// 缩小
    /// </summary>
    public void SuoXiao()
    {
        videoPlayer.GetComponent<Animator>().SetBool("isDa", false);
    }
    /// <summary>
    /// 播放暂停切换
    /// </summary>
    public void Play_ZhanTing()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        playUI.SetActive(!videoPlayer.isPlaying);
        zhanTingUI.SetActive(videoPlayer.isPlaying);
    }
}
