using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS_Basic_Death_Zone : MonoBehaviour
{
    private bool respawn;
    private GameObject collidingPlayerCharacter;
    private GameObject levelManager;
    // Use this for initialization
    void Start()
    {
        levelManager = GameObject.Find("LevelManager");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(respawn)
        {
            //grab the last good checkpoint
            Transform respawnPoint = levelManager.GetComponent<LS_LevelManager>().lastGoodCheckpoint;

            collidingPlayerCharacter.transform.position = respawnPoint.transform.position;
            //its done now turn it off
            respawn = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player Bike")
        {
            //this doesn't work with CC as it would need to happen in
            //other.gameObject.transform.position = respawn.transform.position;

            //turn on respawn
            respawn = true;
            collidingPlayerCharacter = other.gameObject;
        }
    }
}
