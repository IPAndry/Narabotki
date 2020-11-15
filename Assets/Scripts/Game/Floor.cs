using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D( Collider2D other)
    {
        //if (CompareTag("Player"))
        //{
                print("fa");

       this.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);


        //}
    }

    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    print("fa");
    //    other.GetComponent<SpriteRenderer>().color = new Color(160, 160, 100, 100);
    //}
}
