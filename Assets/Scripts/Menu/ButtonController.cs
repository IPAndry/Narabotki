using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip onClick;
    [SerializeField] private AudioClip onHover;

    //[SerializeField] private GameObject startin;

    // Start is called before the first frame update
    void Start()
    {
        //startin.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideElement(GameObject window)
    {
        window.SetActive(false);
    }

    public void ShowElenent(GameObject window)
    {
        window.SetActive(true);
    }

    public void PlaySoundOnDown()
    {
        audioSource.PlayOneShot(onClick);
    }

    public void PlaySoundOnEnter()
    {
        audioSource.PlayOneShot(onHover);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
