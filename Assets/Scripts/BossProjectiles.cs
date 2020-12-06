using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectiles : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;

    int curHealth = 0, maxHealth = 2;

    public GameObject destructionEffect;

    public AudioSource audioDestruction;

    public Animator animator;

    private CameraShake cameraShake;
    private Vector2 direction;
    private float fireSpeed = 3f;

    //float speed = 9f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        curHealth = maxHealth;
        cameraShake = GameObject.FindGameObjectWithTag("ShakeCamera").GetComponent<CameraShake>();
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {//
     //   transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y  + speed * Time.deltaTime);

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (curHealth <= 0)
        {

            Death();
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (player.isAttacking)
            {
                cameraShake.Shake();
            //    transform.localPosition = new Vector2(transform.localPosition.x + fireSpeed *- Time.deltaTime, transform.localPosition.y);
                curHealth -= 1;
            }

            else
            {

                player.curHealth -= 1;
            }


            //   Destroy(gameObject);
        }

    }

    public void Initialize (Vector2 direction)
    {
        this.direction = direction;
    }

    public void Death()
    {
        Instantiate(destructionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);

        audioDestruction.Play();
    }


    // public void ontri
}
