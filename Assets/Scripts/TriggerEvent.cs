using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    GameObject winEffects;
    public GameObject Charater;
    Vector3 translate;

    private void Start()
    {
        winEffects = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Charater)
        {
            //winEffects.SetActive(true);
            //ballGO.transform
            Charater.transform.position = new Vector3(12, 0, 12);
            Debug.Log("Collided");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Charater)
        {
            //winEffects.SetActive(true);
            Charater.transform.position = new Vector3(12, 0, 12);
            Debug.Log("Collided");
        }
    }
}
