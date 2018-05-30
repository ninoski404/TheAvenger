using UnityEngine;

public class InteractionManager : MonoBehaviour {

        void OnCollisionEnter (Collision collisionInfo)
    { 
        if (collisionInfo.collider.tag == "Interactable")
        {
           
            Debug.Log ("item found");
        }



    }

}
