using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingIn : MonoBehaviour
{
    public GameObject player;
    public Transform teleportTarget;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
    }

}
