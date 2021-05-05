using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementsController : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 3.0f;    
    public int vidas = 3;
    GameObject vidasText; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        vidasText = GameObject.Find("Vidas");       
    }

    // Update is called once per frame
    void Update()
    {
        vidasText.GetComponent<Text>().text = vidas.ToString();
    }
    private void FixedUpdate() {
        Vector3 position = rb.position;
        // Primary Movement                 
        position.y = position.y - speed * Time.fixedDeltaTime;    
        
        rb.MovePosition(position);


        if (position.y <= -5){
            Destroy(gameObject);
            
        }
        if (tag == "Rock"){
            vidas -= 1;
        }
    }
}
