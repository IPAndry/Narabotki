using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour, IPointerDownHandler
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
        SceneManager.LoadScene("SampleScene");
    }
}
