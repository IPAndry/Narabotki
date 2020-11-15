using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    [SerializeField] GameObject StarObj;

    Rigidbody2D m_Rigidbody;
    readonly Vector2 force = new Vector2(50, 50);
    bool inAir;


    public Sprite Left;
    public Sprite Right;

    private SpriteRenderer spriteRenderer;

    public AudioClip AudioClip;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null) 
            spriteRenderer.sprite = Right;


        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Star star = StarObj.GetComponent<Star>();

        bool starGet = star.starGeted;


        //print(inAir);

        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.sprite = Left;

            Vector2 position = this.transform.position;
            position.x -= 0.3f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.sprite = Right;

            Vector2 position = this.transform.position;
            position.x += 0.3f;
            this.transform.position = position;
        }

        if (starGet == false)
        {
            if (Input.GetKeyDown(KeyCode.W) && !inAir)
            {
                inAir = true;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7), ForceMode2D.Impulse);


                //{
                //    Vector3 position = this.transform.position;
                //    position.y += 3;
                //    this.transform.position = position;

                if (audioSource == null)
                    audioSource = GetComponent<AudioSource>();
                if (audioSource == null)
                    audioSource = gameObject.AddComponent<AudioSource>();

                audioSource.PlayOneShot(AudioClip);
            }
        }
        if (starGet == true)
        {
            if (Input.GetKey(KeyCode.W) && !inAir)
            {
                inAir = true;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);


                //{
                //    Vector3 position = this.transform.position;
                //    position.y += 3;
                //    this.transform.position = position;

                if (audioSource == null)
                    audioSource = GetComponent<AudioSource>();
                if (audioSource == null)
                    audioSource = gameObject.AddComponent<AudioSource>();

                audioSource.PlayOneShot(AudioClip);
            }
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            inAir = false;
    }
}
