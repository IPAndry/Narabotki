﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackSettings : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject StartGame;
    [SerializeField] GameObject Options;
    [SerializeField] GameObject Exit;
    [SerializeField] GameObject LogoCompany;
    [SerializeField] GameObject LogoGame;
    //[SerializeField] GameObject ;
    //[SerializeField] GameObject ;
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
        StartGame.SetActive(true);
        Options.SetActive(true);
        Exit.SetActive(true);
        LogoCompany.SetActive(true);
        LogoGame.SetActive(true);
    }
}
