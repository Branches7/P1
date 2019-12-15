using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste2 : MonoBehaviour
{
    //public GameObject posisão;
    Transform p;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Plane").transform;
    }

    // Update is called once per frame
    void Update()
    {
        p = GameObject.Find("Plane").transform;
        if (p.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, p.position.y, transform.position.z);
        }
    }
}
