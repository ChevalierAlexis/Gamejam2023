using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int PV = 100;
    private float speed = 0.01f;
    public Attack AttackPattern;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            {
                transform.Translate(-speed, 0, 0);
                this.GetComponent<SpriteRenderer>().flipX=true;
            }

        if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed, 0, 0);
                this.GetComponent<SpriteRenderer>().flipX=false;
            }

        if (Input.GetKey(KeyCode.Z))
            {
                transform.Translate(0, speed, speed);
            }

        if (Input.GetKey(KeyCode.S))
            {
               transform.Translate(0, -speed, -speed);
            }
  
    }
}
