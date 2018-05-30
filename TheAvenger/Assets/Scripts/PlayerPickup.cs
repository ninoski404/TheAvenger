using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickup : MonoBehaviour {

    public Text WinText;
    public Text CountText;
    private int count;

    private void Start()
    {
        count = 0;
        WinText.text = "";
        SetCountText();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Interactable")
        {
            Debug.Log("picking up an item as player");

            count = count + 1;

            SetCountText();
        }
    }
    void SetCountText()
    {
        CountText.text = "count:" + count.ToString();
        if (count >= 5)
        {
            WinText.text = "You win!";
        }
    }

}
