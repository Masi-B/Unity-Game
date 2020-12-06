using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2BossPatrol : MonoBehaviour
{
    // Start is called before the first frame update
    public Level2Boss enemy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Edge")
            enemy.Flip();
    }
}
