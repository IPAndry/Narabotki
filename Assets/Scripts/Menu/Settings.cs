using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Settings : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject SettingsWindow;


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
        SettingsWindow.SetActive(true);
    }

    private void OnMouseDown()
    {

    }
}
