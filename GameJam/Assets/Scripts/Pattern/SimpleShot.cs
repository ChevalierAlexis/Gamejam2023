using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShot : Attack
{
    public override void  pattern()
    {
        GameObject TempBullet = Instantiate(ammo, zePlayer.transform.position, Quaternion.identity);
        bulletList.Add(TempBullet);
        TempBullet.transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
