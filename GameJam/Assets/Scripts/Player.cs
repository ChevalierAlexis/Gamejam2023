using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int PV = 100;
    private float speed = 0.01f;
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
                transform.Translate(0, speed, speed);
            }

        if (Input.GetKey(KeyCode.S))
            {
               transform.Translate(0, -speed, -speed);
            }
        compteur-=Time.deltaTime;
        if(compteur<=0)
        {
            AttackPattern.pattern();
            compteur = AttackPattern.attackSpeed;
        }
    }
}
