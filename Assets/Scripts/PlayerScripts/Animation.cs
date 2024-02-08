using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    //References
    Animator am;
    Movement m;
    [HideInInspector]
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        m = GetComponent<Movement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m.moveDir.x != 0 || m.moveDir.y != 0)
        {
            am.SetBool("Move", true);

            SpriteDirectionChecker();            
        }
        else 
        {
            am.SetBool("Move", false);
            am.SetFloat("MoveX", 0);
            am.SetFloat("MoveY", 0);
        }        
    }

    void SpriteDirectionChecker() 
    {
        if (m.moveDir.x < 0)
        {
            sr.flipX = true;
            am.SetFloat("MoveX", -1);
        }
        if (m.moveDir.x > 0) 
        {
            sr.flipX = false;
            am.SetFloat("MoveX", 1);
        }
        if (m.moveDir.y > 0)
        {            
            am.SetFloat("MoveY", 1);
        }
        if (m.moveDir.y < 0) 
        {
            am.SetFloat("MoveY", -1);
        }
    }
}
