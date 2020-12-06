using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //     Destroy(collision.gameObject);
            //        player.Death();
            player.curHealth -= 1;
            print(player.curHealth);
            

            if (player.curHealth <= 0)
            {
                //      Destroy(collision.gameObject);
                player.Death();
                SceneManager.LoadScene(1);
             //   player.Death();
            }
       //     SceneManager.LoadScene(1);
          //  Application.LoadLevel(Application.loadedLevel);
        }

    }
}
