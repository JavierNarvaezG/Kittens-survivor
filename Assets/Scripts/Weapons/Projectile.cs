using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


/// <summary>
/// Base Script of al projectile behaviours [To be placed on a prefab of weapon that is a projectile]
/// </summary>
public class Projectile : MonoBehaviour
{

    protected Vector3 direction;
    public float destroyAfterSeconds;
    
    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        if (dirx < 0 && diry == 0) //Left
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
        }
        else if (dirx == 0 && diry < 0) //Down
        {
            scale.y = scale.y * -1;
        }
        else if (dirx == 0 && diry > 0) //Up
        {
            scale.x = scale.x * -1;
        }
        else if (dirx > 0 && diry > 0) //Right Up
        {
            rotation.z = 0f;
        }
        else if (dirx > 0 && diry < 0) //Right Down
        {
            rotation.z = -90f;
        }
        else if (dirx < 0 && diry > 0) //Left Up
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = -90f;
        }
        else if (dirx < 0 && diry < 0) //Left Down
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = 0f;
        }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation); 
    }
}
