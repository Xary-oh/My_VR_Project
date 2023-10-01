using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        
    }

  
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            cube.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Da");
            cube.SetActive(true);
        }
    }
}
