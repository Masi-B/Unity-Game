using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObjects : MonoBehaviour 
{
    //for the interactive items in the level
    // Start is called before the first frame update
    public Vector2 platformCoordinates;

   // public Vector2 platformSpeed;

     Transform ts;

    public Player player;

    private CameraShake cameraShake;

    public GameObject destructionEffect;



    int curHealth = 0, maxHealth = 1;



    public GameObject obj ;

     Transform plat;

    Rigidbody2D rigid;
    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = platformCoordinates;
        ts = transform.Find("projectile");
        plat = transform.Find("metroidlike_21");
    }

    // Update is called once per frame
    void Update()
    {

        rigid.velocity = platformCoordinates;

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (curHealth <= 0)
        {

            Death();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
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

    public void Death()
    {
        Instantiate(destructionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
