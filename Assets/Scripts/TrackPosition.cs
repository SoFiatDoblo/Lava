using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPosition : MonoBehaviour
{
    public float moveDistance = 5f; 
    public float moveSpeed = 1f; 

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
         startPosition = transform.position;
        targetPosition = startPosition + new Vector3(moveDistance, 0, 0); 
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = (Mathf.Sin((Time.time - startTime) * moveSpeed) + 1) / 2;
        transform.position = Vector3.Lerp(startPosition, targetPosition, t);
    }
}