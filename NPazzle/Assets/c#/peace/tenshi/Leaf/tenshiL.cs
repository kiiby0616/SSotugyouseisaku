﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenshiL : MonoBehaviour {
  
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "mamono")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "mamonoF")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "mamonoL")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "mamonoW")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "hitoW")
        {
            Destroy(col.gameObject);
        }
    }
}