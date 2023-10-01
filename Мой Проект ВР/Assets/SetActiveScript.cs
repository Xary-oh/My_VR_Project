using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject sphere;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Sphere Deactivated");
            sphere.SetActive(false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Sphere Activated");
            sphere.SetActive(true);
        }
    }
}
