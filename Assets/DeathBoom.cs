using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoom : MonoBehaviour
{

    private bool respawn;
    private GameObject collidingPlayerCharacter;
    private GameObject levelManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (respawn)
        {
            //grab the last good checkpoint
            Transform respawnPoint = levelManager.GetComponent<LS_LevelManager>().lastGoodCheckpoint;

            collidingPlayerCharacter.transform.position = respawnPoint.transform.position;
            //its done now turn it off
            respawn = false;
        }
    }

    private void OnTrigger2D(Collider other)
    {
        if (other.gameObject.tag == "Floor")
        {
            respawn = true;
        }
    }

}
