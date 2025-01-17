using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 每个年份的素材
/// </summary>
public class NianFenSuCai : MonoBehaviour
{
    [Header("每个年份的素材")]
    public GameObject[] suCai;
    [Header("视角")]
    public CinemachineVirtualCameraBase vcam_SanDa;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnEnable()
    {
        vcam_SanDa.MoveToTopOfPrioritySubqueue();

        foreach (var item in suCai)
        {
            item.SetActive(true);
        }
    }

    public void OnDisable()
    {
        foreach (var item in suCai)
        {
            item.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
