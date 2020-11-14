using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Exit : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject ExitWindow;

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
        ExitWindow.SetActive(true);
    }
}
