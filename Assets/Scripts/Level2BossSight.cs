using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2BossSight : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Level2Boss enemy;
    public static bool found { get; set; }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            enemy.Target = other.gameObject;
            found = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enemy.Target = null;
            found = false;
        }
    }
}
