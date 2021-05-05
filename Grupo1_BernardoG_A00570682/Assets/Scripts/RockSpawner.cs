using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject rock;
    float xPos, yPos;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (RockSp ());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RockSp() {
        while (true) {
            xPos = Random.Range (-8, 8);
            yPos = 6;

            Instantiate (rock, new Vector3 (xPos, yPos, 0), Quaternion.identity);

            yield return new WaitForSeconds (1);
        }
    }
}
