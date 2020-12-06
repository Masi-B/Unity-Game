using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigid;

    [SerializeField]
    private float movementSpeed;

    private Animator animator;

    private Vector2 projectileSpeed;
    //flip player

    private bool facingRight;
   
    public  bool attack;

    public bool isAttacking;

     Transform player;

    public GameObject play;

    public GameObject obj;

     Transform playerPos, ts;

    private bool dead;

    public int curHealth = 0, maxHealth = 5;

    public LayerMask enemyDamage;

    public float attackRange;

    [SerializeField]

    private EdgeCollider2D knifeAttack;
       
    /*Test enemy attack;
     */


     
    // Start is called before the first frame update
    void Start()
    {
    //    InvokeRepeating("Respawn", 8, 8);
        facingRight = true;
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerPos = transform.Find("Player");
        ts = transform.Find("projectile");
        curHealth = maxHealth;
        
    }

    public void Update()
    {
        input();

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (curHealth <= 0)
        {
            Death();
        }




    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Move(horizontal);

        Flip(horizontal);

        Melee();

        resetValues();
    }

    //move charactor side ways
    public void Move(float horizontal)
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsTag("Melee"))
        {
            rigid.velocity = new Vector2(horizontal * movementSpeed, rigid.velocity.y);

        }

          //running
        animator.SetFloat("speed",Mathf.Abs( horizontal));

    }



    //flip player 
    public void Flip (float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight )
        {
            facingRight = !facingRight;

            Vector3 vector = transform.localScale;

            vector.x *= -1;

            transform.localScale = vector;
        }

    } 

   

    public void input ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            attack = true;
            rigid.velocity = Vector2.zero;
            isAttacking = true;
        }

    }

     



    public void Melee ()
    {
        if (attack && !animator.GetCurrentAnimatorStateInfo(0).IsTag("Melee"))
        {
            animator.SetTrigger("melee");
            isAttacking = true;
        }

        
    }

    public void MeleeAttack()
    {
        knifeAttack.enabled = !knifeAttack.enabled;
    }



    public void resetValues ()
    {
        attack = false;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
      //  print("COLLISION");
     //   if (collision.gameObject.tag.Equals("Star"))
     //   {
      //      Destroy(gameObject);
     //       Destroy(collision.gameObject);
    //        dead = true;
   //     }

        if (collision.gameObject.tag.Equals("MovingPlatform1") ||
            collision.gameObject.tag.Equals("MovingPlatform2") ||
            collision.gameObject.tag.Equals("MovingPlatform3") ||
            collision.gameObject.tag.Equals("MovingPlatform4"))
        {
            this.transform.parent = collision.transform;
            collision.collider.transform.SetParent(transform);
        }

    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("MovingPlatform1")   ||
            collision.gameObject.tag.Equals("MovingPlatform2")   ||
            collision.gameObject.tag.Equals("MovingPlatform3")   ||
            collision.gameObject.tag.Equals("MovingPlatform4"))
        {
            this.transform.parent = null;
        //    collision.collider.transform.SetParent(null);
        }
    }

    public void Death()
    {
            animator.GetCurrentAnimatorStateInfo(0).IsTag("death");
            Destroy(gameObject);
    }

    //void OnTriggerEnter2D(Collider2D respawn)
    //{

    //    player.transform.position = respawn.transform.position;
    //}



    //private void Respawn()
    //{
    // //   print("RESPAWNING");
    //    if (dead)
    //    {
    //        //   Instantiate(play, transform.position, Quaternion.identity);
    //        transform.position = player.position;

    //    }
    //    dead = false;
    //}
}
