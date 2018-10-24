﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player; //Public variable to store a reference to the player game object
                             //public GameObject player;


    private Vector3 offset;


    void Start()
    {

        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {

        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
