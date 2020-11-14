using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject Slide1;
    [SerializeField] private GameObject Slide2;
    [SerializeField] private GameObject Slide3;

    public int slides = 0;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip End;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Titles();
    }

    IEnumerator SlideOne()
    {
        yield return new WaitForSeconds(10);
        Slide1.SetActive(false);
        slides = 1;
    }

    IEnumerator SlideTwo()
    {
        yield return new WaitForSeconds(10);
        Slide2.SetActive(false);
        slides = 2;
    }

    IEnumerator SlideThree()
    {
        yield return new WaitForSeconds(10);
        Slide3.SetActive(false);
        slides = 3;
    }

    IEnumerator StopMusic()
    {
        yield return new WaitForSeconds(5);
        audioSource.Stop();
        SceneManager.LoadScene("Rainy Pray (Menu)");
    }

    public void Titles()
    {
        if (slides == 0)
            StartCoroutine(SlideOne());

        if (slides == 1)
            StartCoroutine(SlideTwo());

        if (slides == 2)
            StartCoroutine(SlideThree());

        if (slides == 3)
            StartCoroutine(StopMusic());


    }
}
