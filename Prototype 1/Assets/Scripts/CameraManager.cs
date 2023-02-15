using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera.SetActive(true);
            Camera2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Camera.SetActive(false);
            Camera2.SetActive(true);
        }
    }
}
