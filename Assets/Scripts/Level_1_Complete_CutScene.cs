using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Level_1_Complete_CutScene : MonoBehaviour
{
    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        video.Play();

        WaitForSeconds waitForSeconds = new WaitForSeconds(4);

        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(4);
        }
    }
}
