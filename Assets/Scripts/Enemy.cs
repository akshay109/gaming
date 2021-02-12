using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float RotationSpeed;
    public GameObject dust;
   
  

    public void FixedUpdate()
    {
        transform.Rotate(0,0,RotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
           
            Destroy(collision.gameObject);
            
            GameManager.instance.GameOver();
        } 
        else if(collision.gameObject.tag == "Ground")
        {
            GameManager.instance.IncrementScore();
            gameObject.SetActive(false);
           GameObject dustEffect = Instantiate(dust, transform.position, Quaternion.identity);
            Destroy(dustEffect, 2f);
            Destroy(gameObject,3f);
        }
    }
}
