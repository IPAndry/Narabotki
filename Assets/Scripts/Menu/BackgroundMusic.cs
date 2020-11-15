using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip music;
    [SerializeField] private AudioClip soundRain;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource.PlayOneShot(music);
        audioSource.PlayOneShot(soundRain);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
