using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startin : MonoBehaviour
{
    [SerializeField] private GameObject starting;
    public Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        starting.SetActive(true);
        StartCoroutine(AnimationEnd());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AnimationEnd()
    {
        //yield return new WaitForSeconds(animation.normalizedTime = 1.0f);
        print("f");
    }
}
