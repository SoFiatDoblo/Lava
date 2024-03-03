using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public UnityEvent onCollisionEnter; 
    public GameObject prefabToSpawn; 

    void Start()
    {
        audioSource = audioSource ? audioSource : GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
        onCollisionEnter?.Invoke();

        if (prefabToSpawn != null)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}
