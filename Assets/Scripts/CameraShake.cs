﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public void Shake()
    {
        animator.SetTrigger("shake");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
