﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{

    public float speed = 5f;

    public float dead = -4f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < dead)
        {
            Destroy(this.gameObject);
        }
    }
}
