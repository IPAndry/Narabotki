using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{
    [SerializeField] GameObject StarObj;

    public AudioSource _AudioSource1;

    [SerializeField] GameObject _AudioSource2;

    void Start()
    {

        _AudioSource1.Play();

    }


    void Update()
    {
        Star star = StarObj.GetComponent<Star>();

        bool starGet = star.starGeted;


        if (starGet == true)
        {


            _AudioSource1.Stop();

            _AudioSource2.SetActive(true);


            print("ff");

        }

    }

}