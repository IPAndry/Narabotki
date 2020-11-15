using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PersGone : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject Pers;
    [SerializeField] GameObject Dead;

    [SerializeField] GameObject Procent;

    int rando;

    int rando1;

    int random;

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
        Pers.SetActive(false);
        //StartCoroutine(TestCoroutine());

        Invoke("func", 3); // Мы вызываем функцию через 3 секунды



    }

    IEnumerator TestCoroutine()
    {
        yield return new WaitForSeconds(5.0f);
    }

    void func()
    {
        

        rando = Random.Range(1, 101);

        rando1 = Random.Range(1, 101);

        print("Рандом 1 = " + rando);
        print("Рандом 2 = " + rando1);

        if (rando >= rando1)
        {
            Dead.SetActive(true);
        }

        else
        {
            Pers.SetActive(true);
        }
    }

}
