using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankScore : MonoBehaviour
{
    // Start is called before the first frame update

    //ScoreCount.inventory

    public Text rankText;

    char rank;

    string printRank;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateRank();

        printRank = string.Format("{0}",rank);

        rankText.text = printRank.ToString();
    }

    void CalculateRank()
    {
        // ScoreCount.inventory
        //if (GameTime.Equals(null))

        if ((GameTime.minutes < 1 && GameTime.seconds < 10) || ScoreCount.starInventory == 3)
        {
            rank = 'A';
        }

        else if (GameTime.minutes > 1 && GameTime.seconds < 10 || ScoreCount.starInventory == 2)
        {
            rank = 'B';
        }

        else
        {
            rank = 'C';
        }
   
    }
}
