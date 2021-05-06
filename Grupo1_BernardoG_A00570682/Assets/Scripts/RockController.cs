using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockController : MonoBehaviour
{
    Rigidbody rb;
    GameObject player;
    PlayerController playerController;
    private float speed = 3.0f;     
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
        player = GameObject.Find("Cube");
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        Vector3 position = rb.position;
        // Primary Movement                 
        position.y = position.y - speed * Time.fixedDeltaTime;    
        
        rb.MovePosition(position);


        if (position.y <= -5){
            playerController.Vidas-=1; 
            Destroy(gameObject);                       
        }
    }
}
