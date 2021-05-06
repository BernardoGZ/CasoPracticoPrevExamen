using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float horizontal;
    public float speed = 15.0f;
    public int Score;
    public int Vidas;
    GameObject ScoreText;
    GameObject vidasText; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Score = 0;
        Vidas = 3;
        ScoreText = GameObject.Find("Score");
        vidasText = GameObject.Find("Vidas");  
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        ScoreText.GetComponent<Text>().text = Score.ToString();
        vidasText.GetComponent<Text>().text = Vidas.ToString();

        if(Vidas <= 0){
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

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
            transform.localScale = new Vector3(4f, 1f, 1f);
            StartCoroutine(scaleChange());
        }  
        if(other.tag == "Meteors"){
            Destroy(other.gameObject);
            speed = speed/2;
            StartCoroutine(velChange());
        }
    }

    IEnumerator scaleChange( ) {
        while (true) {    
            yield return new WaitForSeconds (6);            
            transform.localScale = new Vector3(2f, 1f, 1f);
        }
    }
    IEnumerator velChange( ) {
        while (true) {    
            yield return new WaitForSeconds (5);            
            speed = speed*2;
        }
    }

}
