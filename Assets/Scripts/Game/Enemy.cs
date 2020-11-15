using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject StarObj;

    public Sprite Normal;
    public Sprite WutFace;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = Normal;


        Star star = StarObj.GetComponent<Star>();

        bool starGet = star.starGeted;

        if (starGet == true)
        {
            spriteRenderer.sprite = WutFace;
        }
    }
}
