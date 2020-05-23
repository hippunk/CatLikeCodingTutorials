using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountVertices : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Debug.Log("Vertices count : "+mesh.vertices.Length);
    }

    
}
