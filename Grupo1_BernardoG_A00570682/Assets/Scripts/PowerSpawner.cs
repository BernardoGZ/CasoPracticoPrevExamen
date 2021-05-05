using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpawner : MonoBehaviour
{
    public GameObject power;
    float xPos, yPos;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (PowerSp ());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PowerSp() {
        while (true) {
            xPos = Random.Range (-8, 8);
            yPos = 6;

            Instantiate (power, new Vector3 (xPos, yPos, 0), Quaternion.identity);

            yield return new WaitForSeconds (15);
        }
    }
}
