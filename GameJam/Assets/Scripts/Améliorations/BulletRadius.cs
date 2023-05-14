using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRadius : Amelioration
{
    public override void Upgrade()
    {   
        Sprite tempStrite= target.AttackPattern.ammo.GetComponent<SpriteRenderer>().sprite;
        var index = target.AttackPattern.ammo.GetComponent<Bullet>().SpriteList.FindIndex(go => go == tempStrite);
        target.AttackPattern.ammo.GetComponent<SpriteRenderer>().sprite = target.AttackPattern.ammo.GetComponent<Bullet>().SpriteList[index+1];
        target.AttackPattern.ammo.GetComponent<Bullet>().GetComponent<CircleCollider2D>().radius += 0.01f;
    }
}
