using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startin : MonoBehaviour
{
    [SerializeField] GameObject Starting;

    // Start is called before the first frame update
    void Start()
    {
        Starting.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
