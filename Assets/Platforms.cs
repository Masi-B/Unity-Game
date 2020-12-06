using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    // Start is called before the first frame update
    //Transform platform;

   //  Vector2 platformCoordinates;

   //  Rigidbody2D rigid;

    

    //public Transform ts;
    float platformSpeed = 2f;

    bool down;

    void Start()
    {
        //platform = transform.Find("metroidlike_21");
        //     rigid = GetComponent<Rigidbody2D>();
        //    rigid.velocity = platformCoordinates;
   //     transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + 1f );
    }

    // Update is called once per frame
    void Update()
    {
      //  transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + platformSpeed * Time.deltaTime);
        moving();
    }




    private void moving()
    {


        //   if (transform != null)
        if (transform.localPosition.y > -4f)
            down = true;
        if (transform.localPosition.y < -7.76f)
            down = false;
        if (down)
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - platformSpeed * Time.deltaTime);
        else
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + platformSpeed * Time.deltaTime);
    }
}
