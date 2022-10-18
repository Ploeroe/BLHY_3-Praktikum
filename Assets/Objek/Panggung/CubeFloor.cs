using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloor : MonoBehaviour
{
// Declare Material to be reconized in the Inspector
    [SerializeField]
    public Material FloorMaterial;

    // Declaring and initializing values for our mesh
    float width = 1.0f;
    float height = 1.0f;
    float thick = 1.0f;

    Texture floorTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];
        var uvs = new Vector2[vertices.Length];
        floorTexture = Resources.Load<Texture>("Textures/Grass");

        //First Layer of 4-Vertices Quad
        vertices[0] = new Vector3(-width, -height, thick);
        vertices[1] = new Vector3(-width, height, thick);
        vertices[2] = new Vector3(width, height, thick);
        vertices[3] = new Vector3(width, -height, thick);

        //uvs for texture the first layer
        uvs[0] = new Vector2(0.0f, 0.5f);
        uvs[1] = new Vector2(0.25f, 0.5f);
        uvs[2] = new Vector2(0.0f, 0.0f);
        uvs[3] = new Vector2(0.25f, 0.0f);

        //Second Layer of 4-Vertices Quad
        vertices[4] = new Vector3(-width, -height, -thick);
        vertices[5] = new Vector3(-width, height, -thick);
        vertices[6] = new Vector3(width, height, -thick);
        vertices[7] = new Vector3(width, -height, -thick);

        //uvs for texture the second layer
        uvs[4] = new Vector2(0.25f, 0.5f);
        uvs[5] = new Vector2(0.5f, 0.5f);
        uvs[6] = new Vector2(0.25f, 0.0f);
        uvs[7] = new Vector2(0.5f, 0.0f);
    
        mesh.vertices = vertices;

        mesh.uv = uvs;

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
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = FloorMaterial;

        // mesh.normals = new Vector3[] {
        //     new Vector3(1.0f , 0.0f, 0.0f),
        //     new Vector3(1.0f , 0.0f, 0.0f),
        //     new Vector3(1.0f , 0.0f, 0.0f),
        //     new Vector3(1.0f , 0.0f, 0.0f),
            
        //     new Vector3(0.0f , 1.0f, 0.0f),
        //     new Vector3(0.0f , 1.0f, 0.0f),
        //     new Vector3(0.0f , 1.0f, 0.0f),
        //     new Vector3(0.0f , 1.0f, 0.0f),

        //     new Vector3(0.0f , 0.0f, 1.0f),
        //     new Vector3(0.0f , 0.0f, 1.0f),
        //     new Vector3(0.0f , 0.0f, 1.0f),
        //     new Vector3(0.0f , 0.0f, 1.0f),

        //  };
    }
}
