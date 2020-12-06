using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarResults : MonoBehaviour
{
    // Start is called before the first frame update
  
    public Text starResults;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              starResults.text = ScoreCount.inventory;
    }
}
