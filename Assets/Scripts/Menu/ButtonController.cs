using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip onClick;
    [SerializeField] private AudioClip onHover;

    [SerializeField] private GameObject window;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClose(GameObject window)
    {
        window.SetActive(false);
    }

    public void OnDown()
    {
        audioSource.PlayOneShot(onClick);

        print("Click");
    }

    public void OnEnter()
    {
        audioSource.PlayOneShot(onHover);

        print("Hover");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
