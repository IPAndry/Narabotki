using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class OnHover : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    public AudioClip AudioClip;
    private AudioSource audioSource;

    public AudioClip AudioClip2;
    private AudioSource audioSource2;

    //Do this when the cursor enters the rect area of this selectable UI object.
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.PlayOneShot(AudioClip);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (audioSource2 == null)
            audioSource2 = GetComponent<AudioSource>();
        if (audioSource2 == null)
            audioSource2 = gameObject.AddComponent<AudioSource>();

        audioSource2.PlayOneShot(AudioClip2);
    }
}