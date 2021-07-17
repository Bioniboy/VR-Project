using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallHide : MonoBehaviour
{
    GameObject wall;
    private bool toggle = false;
    void Start()
    {
        wall = GameObject.Find("Toggle-Wall");
        wall.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (toggle == true)
            {
                wall.SetActive(false);
                toggle = false;
            } else
            {
                wall.SetActive(true);
                toggle = true;
            }
        }
    }
}