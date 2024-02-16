using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<Summary>
// Base script for all weapon controllers
//</Summary>

public class WeaponController : MonoBehaviour
{
    [Header("weapon Stats")]
    public GameObject prefabs;
    public float damage;
    public float speed;
    public float cooldownDuration;
    public float currentCooldown;
    public float pierce;

    // Start is called before the first frame update   
    //The protected keyword is another visibility state, similar to public, but it only allows accessibility to the child class from outside
    //the virtual keyword allows override an method, property, indexer or event declaration on any child class
    //i use this metod be cause i want to try using an "security" metod and saw the limits using this accessibility states.
    protected virtual void Start()
    {
        currentCooldown = cooldownDuration; //At the start set the current cooldown to be the cooldown duration
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown < 0f) //Once the cooldown becomes 0, attack
        {
            Attack();
        }
    }

    protected virtual void Attack() 
    {
        currentCooldown = cooldownDuration;
    }
}
