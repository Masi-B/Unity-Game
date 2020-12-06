using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    private Player player;

    private Transform playerPos;


    private Rigidbody2D rigid;

    private CameraShake cameraShake;

    private Vector2 direction;

    private float fireSpeed = 9f;

    //float speed = 9f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = player.transform;
        cameraShake = GameObject.FindGameObjectWithTag("ShakeCamera").GetComponent<CameraShake>();
        direction = new Vector2(playerPos.position.x, playerPos.position.y);
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {//
     //  transform.position = Vector2.MoveTowards(transform.position, direction, fireSpeed * Time.deltaTime);
     //   transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y  + speed * Time.deltaTime);
        transform.position = Vector2.MoveTowards(transform.position, direction, fireSpeed * Time.deltaTime);

        if (transform.position.x == direction.x && transform.position.y == direction.y)
            Death();
    }

    private void FixedUpdate()
    {
      

        //   rigid.velocity = direction * fireSpeed;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
    /*    print(player.isAttacking);
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (player.isAttacking)
            {
                cameraShake.Shake();
                Death();
            }

            else
            {

                player.curHealth -= 1;
            }


           //    Destroy(gameObject);
        }
        */
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print(player.isAttacking);

        if (collision.gameObject.tag.Equals("Player"))
        {
            if (player.isAttacking)
            {
                cameraShake.Shake();
                Death();
            }

            else
            {
                print("HIT");
                player.curHealth -= 1;
            }


        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        print(player.isAttacking + "EXIT");

   //     if (collision.gameObject.tag.Equals("Player"))
    //    {
            if (player.isAttacking)
            {
                player.isAttacking = false;
            }
    //
     //   }

        
    }

    public void Initialize(Vector2 direction)
    {
        this.direction = direction;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void Death()
    {
        //   Instantiate(destructionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }




    // public void ontri
}

