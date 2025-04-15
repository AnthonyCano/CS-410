using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFOV : MonoBehaviour
{
    public Transform player;
    public float detectionAngle = 60f; // degrees
    public float detectionRange = 10f;
    public AudioSource ghostAudio;
    public ParticleSystem scareEffect;
    private bool hasScaredPlayer = false; // checker for when to play sound and effects
 
    void Start()
    {
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

        if (distance <= detectionRange)
        {
            float dot = Vector3.Dot(transform.forward, toPlayer);
            float angleThreshold = Mathf.Cos(detectionAngle * Mathf.Deg2Rad / 2f);

            if (dot > angleThreshold)
            {
                if (!hasScaredPlayer)
                {
                    hasScaredPlayer = true;

                    if (ghostAudio != null && !ghostAudio.isPlaying)
                        ghostAudio.Play();

                    if (scareEffect != null && !scareEffect.isPlaying)
                        scareEffect.Play();

                    // Debug log
                    Debug.Log("Ghost sees you and reacts!");
                }
            }
            else
            {
                hasScaredPlayer = false;
            }
        }
        else
        {
            hasScaredPlayer = false;
        }
    }
}
