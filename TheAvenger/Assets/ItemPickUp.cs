
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemPickUp : MonoBehaviour
{


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log("item picked up");

            Destroy(gameObject);

        }
    }
}


