using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Yes : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Application.Quit();
    }
}
