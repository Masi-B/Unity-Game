using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformExit : MonoBehaviour
{
    private bool down;
    private float platformSpeed = 2f;

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
        if (transform.localPosition.y > -14.43f)
            down = true;
        if (transform.localPosition.y < -20.97f)
            down = false;
        if (down)
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - platformSpeed * Time.deltaTime);
        else
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + platformSpeed * Time.deltaTime);
    }
}
