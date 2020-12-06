using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroScene : MonoBehaviour
{
    public VideoPlayer video;
    // Start is called before the first frame update
    //   video.Play();
    //    WaitForSeconds waitForSeconds = new WaitForSeconds(4);
    void Start()
    {
         //  video.Play();

      //     nextScene();  
          

    }

    // Update is called once per frame
    void Update()
    {
        video.Play();

        WaitForSeconds waitForSeconds = new WaitForSeconds(4);

        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(2);
        }
    }

    void nextScene()
    {
        
    }
}
