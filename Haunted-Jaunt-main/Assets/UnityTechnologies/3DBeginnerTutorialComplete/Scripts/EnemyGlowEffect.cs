using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
My thoughts are just using the tag system and if john lemon gets within a certain distance
to the enemy they start to glow. Then if I really wanted to I can add the particle trigger
and sound when he gets even closer?
*/ 
public class EnemyGlowEffect : MonoBehaviour
{
    private Transform player;
    private Renderer enemyRenderer;

    private float minDistance = 2f;
    private float maxDistance = 5f;

    public Color farColor = Color.green;
    public Color closeColor = Color.red;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyRenderer = GetComponentInChildren<Renderer>();

        // Replace material[1] with a new instance
        Material[] mats = enemyRenderer.materials;
        mats[1] = new Material(mats[1]);
        enemyRenderer.materials = mats;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        Debug.Log($"Distance: {distance}");

        float t = Mathf.InverseLerp(minDistance, maxDistance, distance);
        Color lerpColor = Color.Lerp(closeColor, farColor, t);

        enemyRenderer.materials[1].color = lerpColor;
    }
}
