using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LS_LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LevelOneLoad()
    {
        SceneManager.LoadScene("Level01Lives&ObstacleTrack");
    }

    public void LevelTwoLoad()
    {
        SceneManager.LoadScene("Level02TimedObstacleTrack");
    }
    public void LevelThreeLoad()
    {
        SceneManager.LoadScene("Level03");
    }
}