using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public Text CounterText;
    public CollisionScript CubeScript;
    void Start()
    {
       
    }

    
    void FixedUpdate()
    {
        CounterText.text = "Score: " + CubeScript.score;
    }
}
