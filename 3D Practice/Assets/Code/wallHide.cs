using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallHide : MonoBehaviour
{
    private bool toggle = false;
    void Start()
    {
// this.gameObject.SetActive(false);
    }

    void Update()
    {
        this.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (toggle == true)
            {
                this.gameObject.SetActive(false);
                toggle = false;
            } else
            {
                this.gameObject.SetActive(true);
                toggle = true;
            }
        }
    }
}
