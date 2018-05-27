
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Player;       //reference to player
    public Vector3 offset;         // variable to offset

    void Update()
    {
        transform.position = Player.position + offset;
        transform.rotation = Quaternion.Euler(65, 0, 0);
    }

   
   
}