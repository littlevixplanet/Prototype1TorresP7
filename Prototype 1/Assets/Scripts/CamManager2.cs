using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            Camera.SetActive(true);
            Camera2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Camera.SetActive(false);
            Camera2.SetActive(true);
        }
    }
}
