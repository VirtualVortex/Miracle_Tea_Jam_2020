﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anims : MonoBehaviour
{

    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Anim = GetComponent<Animator>();

        Anim.SetFloat("MoveX", Input.GetAxis("Vertical"));
        
    }
}
