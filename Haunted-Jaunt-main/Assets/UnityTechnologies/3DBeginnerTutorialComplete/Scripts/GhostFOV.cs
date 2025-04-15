using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFOV : MonoBehaviour
{
    public Transform player;
    public float detectionAngle = 60f; // degrees
    public float detectionRange = 10f;

    void Start()
    {
        // This is what I had to do to get it to work
        // intead of just moving johnlemon into the player field 
        // in the script for the ghost prefab
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                player = playerObj.transform;
            }
        }
    }
    void Update()
    {
        Vector3 toPlayer = (player.position - transform.position).normalized;
        float distance = Vector3.Distance(player.position, transform.position);

        // Check if player is in range
        if (distance <= detectionRange)
        {
            // Dot product between ghost forward and direction to player
            float dot = Vector3.Dot(transform.forward, toPlayer);

            // Calculate the angle threshold
            float angleThreshold = Mathf.Cos(detectionAngle * Mathf.Deg2Rad / 2f);

            // Debugging code
            // if (dot > angleThreshold)
            // {
            //     Debug.Log("Ghost sees you!");
            // }
        }
    }
    
}
