using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    private Rigidbody2D rigid;
    private float movementSpeed = 5f;
    private bool facingRight;

    public EnemyPatrol enemyPatrol;

    public GameObject Target { get;  set; }

    public float attackCoolDown { get; set; }

    public float attackTimer { get; set; }

    public bool meleeRange { get; set; }
    public bool attack { get; set; }

    public float stunTime { get; set; }

    public float beginStun { get; set; }

    private CameraShake cameraShake;

    public Player player;

 //   [SerializeField]
    public GameObject projectile;

    public AudioSource audioShot;

 //   [SerializeField]
 //  private Transform projectilePosition;

    int curHealth = 0, maxHealth = 2;

    public GameObject destructionEffect;

    private float shotCoolDown;

    public float startShotTime;

    void Start()
    {
      //  attackCoolDown = 2;
        facingRight = false;
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        curHealth = maxHealth;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        curHealth = maxHealth;
        cameraShake = GameObject.FindGameObjectWithTag("ShakeCamera").GetComponent<CameraShake>();
        shotCoolDown = startShotTime;

    }

    // Update is called once per frame
    void Update()
    {
        //        transform.localPosition = new Vector2(transform.localPosition.x + 10f * Time.deltaTime, transform.localPosition.y);
        //     animator.SetFloat("speed",20f);if (
        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (stunTime <= 0)
        {
            movementSpeed = 5;
        } 
        
        else
        {
            movementSpeed = 0;
            stunTime -= Time.deltaTime;
        }

        if (curHealth <= 0)
        {
            Instantiate(destructionEffect);

            destructionEffect.SetActive(true);

            Destroy(gameObject);

        }

        if (EnemySight.found && !attack)
         Move();
        if (!EnemySight.found || attack)
          Stop();

        LookAtTarget();

        checkRange();
        if (!meleeRange)
        {

            if (shotCoolDown <= 0)
            {
                //       Instantiate(projectile, transform.position, Quaternion.identity);
                shootPlayer();
                shotCoolDown = startShotTime;
            }
            else
            {
                shotCoolDown -= Time.deltaTime;
            }

        }

    }

    private void checkRange()
    {
        if (Target != null)
        {
            if (Vector2.Distance(transform.position, Target.transform.position) <= 4)
            {
                meleeRange = true;
                attackPlayer();
                
            }
            if (Vector2.Distance(transform.position, Target.transform.position) > 4)
            {
                
                meleeRange = false;
          //      shootPlayer();
            }
        }


    }

    public void Move()
    {

        //running
        animator.SetFloat("speed", 1f);

        transform.Translate(getDirection() * movementSpeed * Time.deltaTime);

    }

    public void Stop()
    {

        animator.SetFloat("speed", 0);

        transform.Translate(getDirection() * 0 * Time.deltaTime);

    }

    public Vector2 getDirection()
    {
        return facingRight ? Vector2.right : Vector2.left;
    }

    public void LookAtTarget()
    {
        if (Target != null)
        {
            float xDir = Target.transform.position.x - transform.position.x;

            if (xDir < 0 && facingRight || xDir > 0 && !facingRight)
            {
                Flip();
            }
        }
    }

    public void Flip()
    {
             facingRight = !facingRight;
             transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
    }

    public void shootPlayer()
    {
        fireProjectile();
 
    }
    public void attackPlayer()
    {
        attackTimer += Time.deltaTime;

         if (attackTimer >= attackCoolDown)
        {
            attack = true;
            attackTimer = 0;

            if (meleeRange)

            {
                cameraShake.Shake();
                player.curHealth -= 1;
            }

            if (player.isAttacking && meleeRange)
            {
                stunTime = beginStun;
                cameraShake.Shake();
                curHealth -= 1;
            }



        }

        if (attack)
        {
            attack = false;
            animator.SetTrigger("melee");
            animator.SetFloat("speed",0);
            transform.Translate(getDirection() * 0 * Time.deltaTime);
            attackCoolDown = 1;
        }
    }

    public void fireProjectile ()
    {
                     
        if (this != null)
        {
            if (facingRight)
            {
                GameObject gameObj = Instantiate(projectile, transform.position, Quaternion.identity);
                gameObj.GetComponent<EnemyProjectile>().Initialize(Vector2.right);
            }

            if (!facingRight)
            {
                GameObject gameObj = Instantiate(projectile, transform.position, Quaternion.identity);
                gameObj.GetComponent<EnemyProjectile>().Initialize(Vector2.left);


            }

            audioShot.Play();
        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       enemyPatrol.OnTriggerEnter2D(collision);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            meleeRange = true;
        }
    }
}
