using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS_Activate_Reactivate_Script : MonoBehaviour
{
    public GameObject Disappear;

    void OnTriggerEnter()
    {
        StartCoroutine(dis);
    }
    IEnumerator dis()
    {
        yield return new WaitForSecondsRealtime(10);
        Disappear.SetActive(false);
    }
 
    if (my platform I am using is currently inactive)
    {
    StartCoroutine(Appear);
}
IEnumerator Appear()
{
    yield return new WaitForSecondsRealtime(10);
    Disappear.SetActive(false);
}
 
}