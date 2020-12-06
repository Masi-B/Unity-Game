using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;

    public static int starInventory;

    public static string inventory;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        inventory = string.Format("{0}", starInventory);
        text.text = starInventory.ToString();
    }
}
