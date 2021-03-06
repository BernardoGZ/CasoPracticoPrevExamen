using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteor;
    float xPos, yPos;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (MetSp ());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MetSp() {
        while (true) {
            xPos = Random.Range (-8, 8);
            yPos = 6;

            Instantiate (meteor, new Vector3 (xPos, yPos, 0), Quaternion.identity);

            yield return new WaitForSeconds (4);
        }
    }
}
