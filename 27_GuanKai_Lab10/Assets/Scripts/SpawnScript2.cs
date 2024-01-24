﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript2 : MonoBehaviour
{
    public GameObject SpawnObject;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {



    }

    void SpawnObjects()
    {

        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject, transform.position, transform.rotation);
    }
}