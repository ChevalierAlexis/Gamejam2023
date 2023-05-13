using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    private int _dammage = 2;

    [SerializeField]
    private float _lifeSpan = 5.0f;
    private float timer;


    public void OnDetection(Ennemy enemy)
    {
        Debug.Log("touche");

        //Detruire les bullet au contact d'un ennemy.
        Destroy(gameObject);
    }



    // Update is called once per frame
    void Update()
    {
        //Je me deplace

        //Check si j'ai vecu assez longtemps
        CheckLifeSpan();

    }

    private void CheckLifeSpan()
    {
        timer += Time.deltaTime;
        if (timer >= _lifeSpan)
        {
            Destroy(gameObject);
        }
    }


}