using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    // Start is called before the first frame update
    public Text resultsText;

  //  public Text starResults;


  //  public string results;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resultsText.text = GameTime.totalTime;
  //      starResults.text = KeyItem.inventory;
    }
}
