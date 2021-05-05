using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float horizontal;
    private float speed = 15.0f;

    public int Score;

    public int Vidas = 3;
    GameObject ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Score = 0;
        ScoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        ScoreText.GetComponent<Text>().text = Score.ToString();

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
            Score += 1;
        }
        if(other.tag == "Power"){
            Destroy(other.gameObject);            
        }   
    }
}
