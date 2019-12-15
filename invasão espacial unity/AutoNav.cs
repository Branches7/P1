using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoNav : MonoBehaviour
{
    [SerializeField]
    NavMeshSurface nav;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.BuildNavMesh();
    }
}
