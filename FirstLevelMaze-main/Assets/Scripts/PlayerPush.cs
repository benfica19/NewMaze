using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public GameObject pushBase;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collider");
        if(collision.gameObject.name == "PlayerCapsule")
        {
            Debug.Log("Player Detected");
        }
    }

    void OnTriggerEnter(Collider other)
    {
       Debug.Log("On Trigger");
    }
}
