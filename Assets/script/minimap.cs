using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    [SerializeField] GameObject cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            cam.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.M)) 
        {
            cam.SetActive(false);
        }
        
    }
}
