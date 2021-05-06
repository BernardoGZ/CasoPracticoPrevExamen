using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedSpawner : MonoBehaviour
{
    public GameObject rock;
    public GameObject power;
    public GameObject meteor;
    float xPos, yPos, w, k;
    public int z;
    
    // Start is called before the first frame update
    void Start()
    {
        // z = 1;
        // z = Random.Range(1,4);
        // if(z == 1){
        //     StartCoroutine (RockSp ());
        // }
        // else if (z == 2){
        //     StartCoroutine (MetSp());
        // }
        // else{
        //     StartCoroutine (PowerSp());
        // }
        StartCoroutine (Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        // z = Random.Range(1,4);
        
    }

    IEnumerator RockSp() {
        while (true) {
            xPos = Random.Range (-8, 8);
            yPos = 6;

            Instantiate (rock, new Vector3 (xPos, yPos, 0), Quaternion.identity);

            yield return new WaitForSeconds (1);
        }
    }
    IEnumerator MetSp() {
        while (true) {
            xPos = Random.Range (-8, 8);
            yPos = 6;

            Instantiate (meteor, new Vector3 (xPos, yPos, 0), Quaternion.identity);

            yield return new WaitForSeconds (4);
        }
    }
    IEnumerator PowerSp() {
        while (true) {
            xPos = Random.Range (-8, 8);
            yPos = 6;

            Instantiate (power, new Vector3 (xPos, yPos, 0), Quaternion.identity);

            yield return new WaitForSeconds (15);
        }
    }
    IEnumerator Spawner(){
        while(true){
            
            z = Random.Range(1,4);
            xPos = Random.Range (-8, 8);
            yPos = 6;
            
            if(z == 1){
                Instantiate (rock, new Vector3 (xPos, yPos, 0), Quaternion.identity);
                yield return new WaitForSeconds (1);                
            }
            else if (z == 2 && w == 0){
                Instantiate (meteor, new Vector3 (xPos, yPos, 0), Quaternion.identity);
                w = 3;
                StartCoroutine(Timer(w));                
                yield return new WaitForSeconds (1);
            }
            else if(z == 3 && k == 0){
                Instantiate (power, new Vector3 (xPos, yPos, 0), Quaternion.identity);
                k = 15;
                StartCoroutine(Timer(k)); 
                yield return new WaitForSeconds (1);
            }
        }

        // z = Random.Range (1, 4);
    }

    IEnumerator Timer(float t){
        yield return new WaitForSeconds (t);
        if(t == 3){
          w = 0;  
        }
        if(t == 15){
            k = 0;
        }
        
    }

}
