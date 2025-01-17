using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoUrl2 : MonoBehaviour
{
    public VideoPlayer video_P;
    public string videoName;
    private void OnEnable()
    {
        video_P.url = Application.streamingAssetsPath + "/" + videoName + ".mp4";
        video_P.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
