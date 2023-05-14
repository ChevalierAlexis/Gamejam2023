using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : Amelioration
{
    public override void Upgrade()
    {
        target.speed = target.speed*1.1f;
    }
}
