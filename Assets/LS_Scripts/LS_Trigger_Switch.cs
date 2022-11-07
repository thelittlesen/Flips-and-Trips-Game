using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS_Trigger_Switch : MonoBehaviour
{
    public GameObject objectToBeActivated;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        print("Death");

        if(other.gameObject.tag == "Player")
        {
            objectToBeActivated.SetActive(true);
        }
    }
}
