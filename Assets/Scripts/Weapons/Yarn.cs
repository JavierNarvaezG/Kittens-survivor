using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yarn : Projectile
{

    YarnController yc;
    
    protected override void Start()
    {
        base.Start();
        yc = FindObjectOfType<YarnController>();
    }
    
    void Update()
    {
        transform.position += direction * yc.speed * Time.deltaTime; //Set the movement of the yarn
    }
}
