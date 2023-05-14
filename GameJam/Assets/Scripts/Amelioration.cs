using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amelioration : MonoBehaviour
{
    public Player target;
    public GameObject Add;
    
    void Start()
    {
        var listplayer = FindObjectsOfType<Player>();
       target = listplayer[0];
    }

    public virtual void Upgrade()
    {

    }

    public virtual void powerUp()
    {

    }
}
