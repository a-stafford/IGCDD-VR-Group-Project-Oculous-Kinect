﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour {

    public GameObject boxes;
    public GameObject character;

    void Update () {

        boxes = GameObject.FindWithTag("Box");
        if (boxes == null)
        {
            SceneManager.LoadScene("Level 2");
            die();
        }
    }

    void die()
    {
        Destroy(character);
    }
}
