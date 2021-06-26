using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " collided with " + gameObject.name);
        collision.transform.position = new Vector3(x: -100, y: 1, z: -400);

    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " colliding with " + gameObject.name);
        collision.transform.position = new Vector3(x: -100, y: 1, z: -400);

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " ended collision with " + gameObject.name);
        collision.transform.position = new Vector3(x: 12, y: 1, z: 15);


    }
}
