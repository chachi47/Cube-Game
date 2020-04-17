﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public NewBehaviourScript movement;

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle")
        {
           movement.enabled = false;
           FindObjectOfType<GameManger>().EndGame();
        }
    }
}
