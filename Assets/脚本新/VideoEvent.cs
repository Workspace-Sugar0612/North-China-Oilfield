using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
/// <summary>
/// 视频播放完成事件
/// </summary>
public class VideoEvent : MonoBehaviour
{

    public UnityEvent videoEnt;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VideoPlayer>().loopPointReached += VideoEvent_loopPointReached;
    }

    private void VideoEvent_loopPointReached(VideoPlayer source)
    {
        Debug.Log("开始播放下一个动画。。。。");
        videoEnt.Invoke();
    }
    public UnityEvent onDisableEvent;
    public void OnDisable()
    {
        Debug.Log("VideoEvent OnDisable...");
        onDisableEvent.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
