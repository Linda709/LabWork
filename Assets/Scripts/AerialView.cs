using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AerialView : MonoBehaviour
{

    public GameObject ball;
    private Vector3 offset = new Vector3(-6.08f, 4.16f, -0.08f);

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + offset;   
    }
}
