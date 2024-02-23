using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YarnController : WeaponController
{   
    protected override void Start()
    {
        base.Start();
    }

    //there we are overriding the attack method on weapon controller and the same thing with Start()
    protected override void Attack() 
    {
        base.Attack();
        GameObject spawnedYarn = Instantiate(prefabs);
        spawnedYarn.transform.position = transform.position; //Assign the position to be the same as this object which is parented to the player
        spawnedYarn.GetComponent<Yarn>().DirectionChecker(m.moveDir); //Reference and set the direction
    }
}
