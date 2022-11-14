using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LS_KillPlayer : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.transform.position = respawnPoint.transform.position;
        
        for(int i = 0; i<Player.childCount;i++)
        {
            Transform subObject = Player.GetChild(i);
            subObject.GetComponent<LS_ResetRBSub>().ResteMe();
        }
    }
}
