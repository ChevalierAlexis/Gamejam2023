using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perforation : Amelioration
{
    public override void Upgrade()
    {
        target.AttackPattern.ammo.GetComponent<Bullet>().traversable += 1;
    }
}
