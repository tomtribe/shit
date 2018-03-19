using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPath001 : MonoBehaviour {

    //the speed that the object will move along the path
    public float speed = 2.0f;

    //If distance between destination point and reach object is less than this, then change game object
    public float reach = 1.0f;

    public int current = 0;

    public Transform[] route;

    private void Start()
    {
        
    }

    private void Update()
    {
        Vector3 dir = route [current].position - transform.position;

        transform.position += dir * Time.deltaTime * speed;

        if(dir.magnitude <= reach)
        {
            current++;
        }

        if (current >= route.Length)
        {
            current = 0;
        }
    }

    private void OnDrawGizmos()
    {
        if (route.Length > 0)
        {
            for (int i = 0; i < route.Length; i++)
            {
                if (route[i] != null)
                {
                    Gizmos.DrawSphere(route[i].position, reach);
                }
            }
        }
    }
}
