using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 3.0f;    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
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
            Destroy(gameObject);            
        }
    }
}
