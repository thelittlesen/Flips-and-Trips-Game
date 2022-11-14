using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS_ResetRBSub : MonoBehaviour
{

    private Vector3 relativeStartPosition;
    private Rigidbody2D thisRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        relativeStartPosition = transform.position;
        thisRigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void ResteMe()
    {
        thisRigidBody.velocity = new Vector2(0,0);
        thisRigidBody.angularVelocity = 0f;
        transform.rotation = Quaternion.identity;
        transform.position = relativeStartPosition;
    }


}
