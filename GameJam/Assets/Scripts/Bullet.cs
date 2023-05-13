using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    public int _dammage = 0;
    public float speed;
    private float timer;
    public int traversable;


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("touche");
        var _enemyComponent = other.GetComponent<Ennemy>();
        if (_enemyComponent != null)
        {
            _enemyComponent.PV-=_dammage;
            if (_enemyComponent.PV<=0)
            {
                Destroy(other.gameObject);
            }
            traversable-=1;
            if (traversable<=0)
            {
                Destroy(gameObject);
            }
            
        }
        
    }
    
    void BulletMove()
    {
        transform.position = transform.position+(transform.forward*speed);
    }

    
    private void CheckLifeSpan()
    {
        timer += Time.deltaTime;
        if (timer >= 5.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
            BulletMove();
            CheckLifeSpan();
    }


}