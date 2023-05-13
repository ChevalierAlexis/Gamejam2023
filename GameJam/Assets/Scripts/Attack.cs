using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float speed;
    private int degats;
    private float attackSpeed;
    public GameObject ammo;
    public List<GameObject> bulletList;

    public virtual void pattern()
    {

    }
    void BulletMove()
    {

    }
    void Update()
    {
        foreach(GameObject bullet in bulletList)
        {
            BulletMove(bullet);
        }
    }
}
