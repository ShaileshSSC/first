using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class chaseScript : MonoBehaviour
{
    GameObject[] Objects;
    //The target player
    public Transform Player;
    //At what distance will the enemy walk towards the player?
    public float walkingDistance = 100.0f;
    //In what time will the enemy complete the journey between its position and the players position
    public float smoothTime = 1.0f;
    //Vector3 used to store the velocity of the enemy
    private Vector3 smoothVelocity = Vector3.zero;
    //Call every frame

   
    void Update()
    {
        //Look at the player
        transform.LookAt(Player);
        //Calculate distance between player
        float distance = Vector3.Distance(transform.position, Player.position);
        //If the distance is smaller than the walkingDistance
        if (distance < walkingDistance)
        {
            //Move the enemy towards the player with smoothdamp
            transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref smoothVelocity, smoothTime);
        }
    }
}