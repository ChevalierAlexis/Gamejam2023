using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float compteur;
    public float tempsRespawn;
    public List<GameObject> EnnemisASpawner;

    void Update()
    {
        compteur -= Time.deltaTime;
        if (compteur <= 0)
        {
            var choixEnnemi = Random.Range(0,EnnemisASpawner.Count);
            GameObject EnnemiSpawne = Instantiate(EnnemisASpawner[choixEnnemi], transform.position, Quaternion.identity);
            compteur = tempsRespawn;
        }
    }
}
