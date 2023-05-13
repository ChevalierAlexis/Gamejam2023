using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float vitesse;
    public int degats;
    public float attackSpeed;
    public GameObject ammo;
    public List<GameObject> bulletList;
    private float compteur;
    public Player zePlayer;

    void Start()
    {
        ammo.GetComponent<Bullet>()._dammage = degats;
        ammo.GetComponent<Bullet>().speed = vitesse;
    }

    public virtual void pattern()
    {
        
    }



    void Update()
    {
       
        compteur-=Time.deltaTime;
        if(compteur<=0)
        {
            pattern();
            compteur = attackSpeed;
        }
    }



}
