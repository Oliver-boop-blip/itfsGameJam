﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GemuManaga : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");


        }
    }
}
