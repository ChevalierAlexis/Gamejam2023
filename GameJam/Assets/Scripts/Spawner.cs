using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float compteur;
    public float tempsRespawn;
    public List<GameObject> EnnemisASpawner;
    public int ennemiesspawned;
    public int probaBouclier = 0;
    public int probaMil = 0;

    void Update()
    {
        compteur -= Time.deltaTime;
        if (compteur <= 0)
        {
            var spawnPosition = new Vector3(0,0,0);
            var choixEnnemi = Random.Range(0,101);
            if (choixEnnemi<100-(probaBouclier+probaMil))
            {
                choixEnnemi = 0;
            }
             else if (choixEnnemi<100-probaMil)
            {
                choixEnnemi = 1;
            }
            else
            {
                choixEnnemi = 2;
            }
            var Axe = Random.Range(0,2);
            if (Axe==0)
            {
                spawnPosition = new Vector3(Random.Range(-12,12),transform.position.y,transform.position.z);
            }
            else
            {
                spawnPosition = new Vector3(transform.position.x,Random.Range(-6,6),transform.position.z);
            }
            GameObject EnnemiSpawne = Instantiate(EnnemisASpawner[choixEnnemi], spawnPosition, Quaternion.identity);
            ennemiesspawned+=1;
            compteur = tempsRespawn;
        }
    }
}
