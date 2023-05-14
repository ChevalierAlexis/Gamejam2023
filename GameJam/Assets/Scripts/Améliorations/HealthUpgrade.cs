using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpgrade : Amelioration
{
    public override void Upgrade()
    {
        target.PV+=10;
    }
}
