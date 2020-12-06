using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    // Start is called before the first frame update
    public Text gameTime;
    public static float time = 0f;
    public static int seconds , minutes;
    public static string totalTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        seconds = (int)(time % 60);
        minutes = (int)(time / 60) % 60;
    //    hour = (int)(time / 3600) % 24;

        totalTime = string.Format("{0:0}:{1:00}",minutes,seconds);

        gameTime.text = totalTime.ToString();
    }
}
