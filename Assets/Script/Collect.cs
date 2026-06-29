using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private int score = 0;
    private bool inRange = false;
    private GameObject currentPickup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            Debug.Log("collision");
            inRange = true;
            currentPickup = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            inRange = false;
            currentPickup = null;
        }
    }

    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            currentPickup.SetActive(false);
            Debug.Log("Gone");
            score = score ++;
            Debug.Log($"Current score: {score}");
        }
    }
}