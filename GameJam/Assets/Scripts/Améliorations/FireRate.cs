using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRate : Amelioration
{
    public override void Upgrade()
    {
        target.AttackPattern.attackSpeed = target.AttackPattern.attackSpeed*1.15f;
    }
}
