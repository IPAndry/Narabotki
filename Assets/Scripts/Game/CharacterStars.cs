using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStars : MonoBehaviour
{
    [SerializeField] GameObject StarObj;
    [SerializeField] GameObject Char;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Star star = StarObj.GetComponent<Star>();

        bool starGet = star.starGeted;

        if (starGet == true)
        {
            Char.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
        }


    }
}
