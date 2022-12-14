using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS_Death_Collision : MonoBehaviour
{
    private bool respawn;
    private GameObject collidingPlayerCharacter;
    private GameObject levelManager;
    // Use this for intialization
    void Start()
    {
        levelManager = GameObject.Find("LevelManager");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(respawn)
        {
            Transform respawnPoint = levelManager.GetComponent<LS_LevelManager>().lastGoodCheckpoint;

            collidingPlayerCharacter.transform.position = respawnPoint.position;
            //its done now turn it off
            respawn = false;
        }
    }

    private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            //this doesn't work with CC as it would need to happen in
            //other.gameObject.transform.position = respawnPoint.transform.position;

            //turn on respawn
            respawn = true;
            collidingPlayerCharacter = hit.gameObject;
            
        }
    }
}
