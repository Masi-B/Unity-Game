using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformExit1 : MonoBehaviour
{
    private bool right;
    private float platformSpeed = 3f;

    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moving();
    }

    /*Created on my own with some help from
     * https://www.youtube.com/watch?v=DQYj8Wgw3O0
    */
    private void moving()
    {


        //   if (transform != null)
        if (transform.localPosition.x > 17.33f)
            right = false;
        if (transform.localPosition.x < 7.74f)
            right = true;
        if (right)
            transform.localPosition = new Vector2(transform.localPosition.x + platformSpeed * Time.deltaTime, transform.localPosition.y);
        else
            transform.localPosition = new Vector2(transform.localPosition.x - platformSpeed * Time.deltaTime, transform.localPosition.y);
    }
}
