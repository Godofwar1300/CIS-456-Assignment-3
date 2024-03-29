﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (CJ Green)
 * (FollowPlayer.cs)
 * (Assignment 3)
 * (This is the script responsible for the camera following the player.)
*/


public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(30, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
