using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    private static RespawnManager _instance;
    public Vector3 CatCheckpoint;
    public Vector3 CameraCheckpoint;

    // Start is called before the first frame update
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ResetCheckPoints()
    {
        CatCheckpoint = Vector3.zero;
        CameraCheckpoint = Vector3.zero;
    }
}
