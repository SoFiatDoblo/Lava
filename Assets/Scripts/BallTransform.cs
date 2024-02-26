using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public float speed = 1.0f; 

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float scale = Mathf.PingPong(Time.time * speed, 1)+1; 
       transform.localScale = new Vector3(scale, scale, scale);
    }
}
