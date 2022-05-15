using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject Camera1;
    public GameObject Camera2;        
  

    // Update is called once per frame
    void Update()
    {
       if ( Input.GetButtonDown ("Key1"))
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
       if (Input.GetButtonDown ("Key2"))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
    }
}
