using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LS_KillPlayer : MonoBehaviour
{
    private void Start()
    {
        //OnTriggerEnter.gameObject.tag("Floor");

    }
    private void OnTriggerEnter(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ihavecollideed");
        }
        //Debug.Log("Ihavecollideed");
        SceneManager.LoadScene(sceneName: "Level01Lives&ObstacleTrack");
    }
}
