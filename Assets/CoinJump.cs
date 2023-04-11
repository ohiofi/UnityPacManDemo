using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 0.001f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 10){
            speed = -speed;
        }
        else if(transform.position.y < 0){
            speed = -speed;
        }

        transform.Translate(Vector3.up * speed);
    }
}
