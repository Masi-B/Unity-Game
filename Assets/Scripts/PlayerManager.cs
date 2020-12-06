using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //select animator
    Animator animator;

    bool running , walking , standing = false;

    private Rigidbody2D myRigidBody;

   // Player player;

    [SerializeField]
    private float speed;


    // Start is called before the first frame update
    void Start()
    {
        //     animator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();

     //   player.curHealth = player.maxHealth;
    }

    // Update is called once per frame

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Move();
        /*
        if ( (Input.GetKeyDown(KeyCode.D))) {

            animator.SetInteger("State",1);
            walking = true;
        }

        if ( (Input.GetKeyUp(KeyCode.D)))
        {
            animator.SetInteger("State", 0);
            walking = false;
            standing = true;
            running = false;
        }

        if ( Input.GetKeyDown(KeyCode.D ) && Input.GetKeyDown(KeyCode.LeftShift) || 
            Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.RightShift) )
        {          
          
                     animator.SetInteger("State", 2);
                     running = true;
                     walking = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            if (running)
            {
                animator.SetInteger("State", 1);
                running = false;
                walking = true;
            }
            else
            {
                animator.SetInteger("State", 0);
                walking = false;
                standing = true;
                running = false;

            }
        }

    //    if (Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.D)) 
   //     {
       //     if (Input.GetKeyDown(KeyCode.D ))
   //             animator.SetInteger("State", 1);
         //   else
           //    animator.SetInteger("State", 0);
  //      } 
                */
    }

    private void Move()
    {
        myRigidBody.velocity = Vector2.left;
    }


}
