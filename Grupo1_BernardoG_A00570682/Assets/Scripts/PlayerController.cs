using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float horizontal;
    private float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        // Debug.Log(rb.position);
    }
    private void FixedUpdate() {
        Vector3 position = rb.position;
        // Primary Movement
        if (Input.GetKey(KeyCode.A)  &&(position.x > -11))
        {            
            position.x = position.x + horizontal * Time.fixedDeltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D) && (position.x < 11))
        {            
            position.x = position.x + horizontal * Time.fixedDeltaTime * speed;
        }

        
        rb.MovePosition(position);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Rock"){
            Destroy(other.gameObject);
        }
        if(other.tag == "Power"){
            Destroy(other.gameObject);
            Vector3 powerup;
        }   
    }
}
