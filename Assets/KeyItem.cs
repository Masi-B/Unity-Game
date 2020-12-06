using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyItem : MonoBehaviour
{
    // Start is called before the first frame update
    public static string inventory;

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
            ScoreCount.starInventory += 1;
            Destroy(gameObject);

            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(3);
            }

            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                SceneManager.LoadScene(5);
            }

            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                SceneManager.LoadScene(7);
            }
        }


    }

}
