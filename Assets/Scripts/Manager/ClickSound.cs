using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    private AudioSource audioSource;


    private void Start()    
    {
        Debug.Log("create");
        audioSource = GetComponent<AudioSource>();
        Debug.Log(transform.parent.name);
    }

    private void Update()
    {
        if (audioSource.isPlaying)
            Debug.Log("asdsas");

        if(!audioSource.isPlaying)
        {
            Destroy(gameObject);
        }

    }
}
