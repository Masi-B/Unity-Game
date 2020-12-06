using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformExit2 : MonoBehaviour
{
    private bool right;
    private float platformSpeed = 7f;

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
        if (transform.localPosition.x > 7.5f)
            right = false;
        if (transform.localPosition.x < -11.35f)
            right = true;
        if (right)
            transform.localPosition = new Vector2(transform.localPosition.x + platformSpeed * Time.deltaTime, transform.localPosition.y);
        else
            transform.localPosition = new Vector2(transform.localPosition.x - platformSpeed * Time.deltaTime, transform.localPosition.y);
    }
}
