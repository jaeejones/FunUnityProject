﻿using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    //The void Start() that was originally here is used for initialization
    //The force which is added when the player jumps
    //This can be chaneged in the Inspector window
    public Vector2 jumpForce = new Vector2(0, 300); //vector 2 stores two values x (left to right vertical) and y(up and down horiztonal)
    
    void Update () {

          //Jump
        if(Input.GetKeyUp("space")) //use the space key on your keyboard.
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);  //Jael jumpforce was initialized with a value called new Vector2 at the start fo this program.
   
        }

        //die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
     }
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}

