using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darken : MonoBehaviour
{
    public Light light;

    void Start()
    {
        // light = GetComponent<Light>();
    }

    void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            light.color = Color.black;
        }
    }
}
