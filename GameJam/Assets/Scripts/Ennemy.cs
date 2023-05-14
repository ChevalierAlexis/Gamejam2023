using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public int PV;

    [SerializeField]
    private float speed;

    public Player target;
    public int degats;
    private float cooldown = 1f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        var listplayer = FindObjectsOfType<Player>();

        rb = GetComponent<Rigidbody2D>();

        target = listplayer[0];
        if(transform.position.x>target.transform.position.x)
        {
            this.GetComponent<SpriteRenderer>().flipX=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>target.transform.position.x)
        {
            this.GetComponent<SpriteRenderer>().flipX=true;
        }
        if(transform.position.x<target.transform.position.x)
        {
            this.GetComponent<SpriteRenderer>().flipX=false;
        }


        //float step = speed*Time.deltaTime;
        //transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);

        var dir = target.transform.position - transform.position;
        rb.AddForce(dir  * speed) ;
        rb.velocity = rb.velocity.normalized * speed;


        if (Vector2.Distance(transform.position,target.transform.position)<5f)
        {
        cooldown-=Time.deltaTime;
        if(cooldown<=0)
        {
            EnnemyAttack();
            cooldown = 1f;
        }
            
        }

    }
    void EnnemyAttack()
    {
        target.PV -= degats;
    }

}