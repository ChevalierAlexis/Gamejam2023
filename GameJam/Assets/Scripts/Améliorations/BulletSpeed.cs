using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : Amelioration
{
    public override void Upgrade()
    {
        target.AttackPattern.ammo.GetComponent<Bullet>().speed = target.AttackPattern.ammo.GetComponent<Bullet>().speed*1.05f;
    }
}
