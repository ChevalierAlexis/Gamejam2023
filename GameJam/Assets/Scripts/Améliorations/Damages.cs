using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damages : Amelioration
{
    public override void Upgrade()
    {
        target.AttackPattern.ammo.GetComponent<Bullet>()._dammage += 10;
    }
}
