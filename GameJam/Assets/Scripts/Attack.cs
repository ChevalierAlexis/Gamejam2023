using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float speed;
    private int degats;
    public float attackSpeed;
    public GameObject ammo;
    public List<GameObject> bulletList;
    private float timer;

    public virtual void pattern()
    {
        
    }

    void BulletMove(GameObject bulletToMove)
    {
        bulletToMove.transform.position = bulletToMove.transform.position+(gameObject.transform.forward*speed);
    }

    void Update()
    {
        foreach(GameObject bullet in bulletList)
        {
            BulletMove(bullet);
            CheckLifeSpan(bullet);
        }
    }

    private void CheckLifeSpan(GameObject bulletToCheck)
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            Destroy(bulletToCheck);
        }
    }
}
