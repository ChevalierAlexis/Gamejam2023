using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int PV = 100;
    private float speed = 100f;
    public Attack AttackPattern;
    private float compteur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            {
                transform.Translate(-speed, 0, 0);
            }

        if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed, 0, 0);
            }

        if (Input.GetKey(KeyCode.Z))
            {
                transform.Translate(0, 0, speed);
            }

        if (Input.GetKey(KeyCode.S))
            {
               transform.Translate(0, 0, -speed);
            }
        compteur-=Time.deltaTime;
        if(compteur<=0)
        {
            
            compteur = AttackPattern.speed;
        }
    }
}
