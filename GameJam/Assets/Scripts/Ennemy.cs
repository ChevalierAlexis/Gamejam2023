using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    private int PV;
    private float speed;
    public Player target;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed*Time.deltaTime;
         transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);
         if (Vector2.Distance(transform.position,target.transform.position)<5f)
         {
            EnnemyAttack();
         }
    }
    void EnnemyAttack()
    {

    }
}