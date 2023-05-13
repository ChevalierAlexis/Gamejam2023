using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float compteur;
    private float tempsRespawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        compteur -= Time.deltaTime;
        if (compteur <= 0)
        {
            compteur = tempsRespawn;
        }
    }
}
