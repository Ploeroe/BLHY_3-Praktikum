using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMonitor : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;

    // Declaring and initializing values for our mesh
    float width = 5.0f;
    float height = 0.5f;
    float thick = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var baseMonitor = new Vector3[8];

        //First Layer of 4-baseMonitor Quad
        baseMonitor[0] = new Vector3(-width, -height, thick);
        baseMonitor[1] = new Vector3(-width, height, thick);
        baseMonitor[2] = new Vector3(width, height, thick);
        baseMonitor[3] = new Vector3(width, -height, thick);

        //Second Layer of 4-baseMonitor Quad
        baseMonitor[4] = new Vector3(-width, -height, -thick);
        baseMonitor[5] = new Vector3(-width, height, -thick);
        baseMonitor[6] = new Vector3(width, height, -thick);
        baseMonitor[7] = new Vector3(width, -height, -thick);
    
        mesh.vertices = baseMonitor;

        mesh.triangles = new int[]{
            2, 1, 0,
            3, 2, 0, //First Face
            3, 0, 4,
            4, 7, 3, //Second Face
            3, 6, 2,
            3, 7, 6, //Third Face
            6, 5, 2,
            5, 1, 2, //Fourth Face
            5, 6, 4,
            6, 7, 4, //Fifth Face
            1, 5, 4,
            4, 0, 1  //Sixth Face
        };
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = cubeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
