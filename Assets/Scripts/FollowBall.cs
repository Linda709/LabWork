using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball;

    private Vector3 offset = new Vector3(0.0f, 1.0f, -10.0f);


    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + offset;
    }
}
