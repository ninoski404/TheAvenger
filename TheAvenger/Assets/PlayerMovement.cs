
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	
	// Update is called once per frame
	void Update () 
       
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 200.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 4.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }

    
}
