using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartMenu : MonoBehaviour
{
 //   public VideoPlayer video;
    /* Menu, should start game is start game is clicked, 
     * or quit game if quit is pressed
     */
    
    public void MainMenu ()
    {
     //   video.Play();
    //    WaitForSeconds waitForSeconds = new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
       
        Application.Quit();
    }

    public void ReturnToMain ()
    {
        SceneManager.LoadScene(0);
    }

    
}