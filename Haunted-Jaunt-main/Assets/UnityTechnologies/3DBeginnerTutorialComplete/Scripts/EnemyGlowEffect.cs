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
    
    private float minDistance = 3f;
    private float maxDistance = 8f;
    
    public Color farColor =  Color.white;
    public Color closeColor = Color.red;
    
}
