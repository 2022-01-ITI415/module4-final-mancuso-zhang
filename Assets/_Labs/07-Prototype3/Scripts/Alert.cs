using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    public GameObject alertText;

    void Start()
    {
        alertText.SetActive(false);
    }

    void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            alertText.SetActive(true);
        }
    }

    void OnTriggerExit (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            alertText.SetActive(false);
        }
    }

}

