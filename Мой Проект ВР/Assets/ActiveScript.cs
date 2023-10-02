using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
    public GameObject sphere;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)){

            Debug.Log("Object is activated");
            sphere.SetActive(true);
        }

        if (Input.GetKey(KeyCode.D))
        {

            Debug.Log("Object is deactivated");
            sphere.SetActive(false);
        }
    }
}
