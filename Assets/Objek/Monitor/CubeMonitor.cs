using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMonitor : MonoBehaviour
{
    [SerializeField]
    public Material CubeMonitorMaterial;

    // Declaring and initializing values for our mesh
    float width = 5f;
    float height = 0.5f;
    float thick = 10f;

        Texture CubeMonitorTexture;

    // Start is called before the first frame update
   void Start()
    {   
    
    Mesh mesh = new Mesh();
    var vertices = new Vector3[24];
    var uvs = new Vector2[vertices.Length];

    CubeMonitorTexture = Resources.Load<Texture>("Textures/Monitor");

        vertices[0] = new Vector3(width, height, thick);
        vertices[1] = new Vector3(width, -height, thick);
        vertices[2] = new Vector3(width, height, -thick);
        vertices[3] = new Vector3(width, -height, -thick);

        uvs[0] = new Vector2(1.0f, 1.0f);
        uvs[1] = new Vector2(1.0f, 0.0f);
        uvs[2] = new Vector2(0.0f, 1.0f);
        uvs[3] = new Vector2(0.0f, 0.0f);

        vertices[4] = new Vector3(width, height, thick);
        vertices[5] = new Vector3(-width, height, thick);
        vertices[6] = new Vector3(width, height, -thick);
        vertices[7] = new Vector3(-width, height, -thick);

        uvs[4] = new Vector2(1.0f, 1.0f);
        uvs[5] = new Vector2(1.0f, 0.0f);
        uvs[6] = new Vector2(0.0f, 1.0f);
        uvs[7] = new Vector2(0.0f, 0.0f);

        vertices[8] = new Vector3(width, height, thick);
        vertices[9] = new Vector3(-width, height, thick);
        vertices[10] = new Vector3(width, -height, thick);
        vertices[11] = new Vector3(-width, -height, thick);

        uvs[8] = new Vector2(1.0f, 1.0f);
        uvs[9] = new Vector2(1.0f, 0.0f);
        uvs[10] = new Vector2(0.0f, 1.0f);
        uvs[11] = new Vector2(0.0f, 0.0f);

        vertices[12] = new Vector3(-width, height, thick);
        vertices[13] = new Vector3(-width, -height, thick);
        vertices[14] = new Vector3(-width, height, -thick);
        vertices[15] = new Vector3(-width, -height, -thick);

        uvs[12] = new Vector2(1.0f, 1.0f);
        uvs[13] = new Vector2(1.0f, 0.0f);
        uvs[14] = new Vector2(0.0f, 1.0f);
        uvs[15] = new Vector2(0.0f, 0.0f);

        vertices[16] = new Vector3(width, -height, thick);
        vertices[17] = new Vector3(-width, -height, thick);
        vertices[18] = new Vector3(width, -height, -thick);
        vertices[19] = new Vector3(-width, -height, -thick);

        uvs[16] = new Vector2(1.0f, 1.0f);
        uvs[17] = new Vector2(1.0f, 0.0f);
        uvs[18] = new Vector2(0.0f, 1.0f);
        uvs[19] = new Vector2(0.0f, 0.0f);

        vertices[20] = new Vector3(width, height, -thick);
        vertices[21] = new Vector3(-width, height, -thick);
        vertices[22] = new Vector3(width, -height, -thick);
        vertices[23] = new Vector3(-width, -height, -thick);

        uvs[20] = new Vector2(1.0f, 1.0f);
        uvs[21] = new Vector2(1.0f, 0.0f);
        uvs[22] = new Vector2(0.0f, 1.0f);
        uvs[23] = new Vector2(0.0f, 0.0f);

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];

        colors[0] = new Color32(211, 211, 211, 255);
        colors[1] = new Color32(211, 211, 211, 255);
        colors[2] = new Color32(211, 211, 211, 255);
        colors[3] = new Color32(211, 211, 211, 255);

        colors[4] = new Color32(211, 211, 211, 255);
        colors[5] = new Color32(211, 211, 211, 255);
        colors[6] = new Color32(211, 211, 211, 255);
        colors[7] = new Color32(211, 211, 211, 255);

        colors[8] = new Color32(211, 211, 211, 255);
        colors[9] = new Color32(211, 211, 211, 255);
        colors[10] = new Color32(211, 211, 211, 255);
        colors[11] = new Color32(211, 211, 211, 255);

        colors[12] = new Color32(211, 211, 211, 255);
        colors[13] = new Color32(211, 211, 211, 255);
        colors[14] = new Color32(211, 211, 211, 255);
        colors[15] = new Color32(211, 211, 211, 255);

        colors[16] = new Color32(211, 211, 211, 255);
        colors[17] = new Color32(211, 211, 211, 255);
        colors[18] = new Color32(211, 211, 211, 255);
        colors[19] = new Color32(211, 211, 211, 255);

        colors[20] = new Color32(211, 211, 211, 255);
        colors[21] = new Color32(211, 211, 211, 255);
        colors[22] = new Color32(211, 211, 211, 255);
        colors[23] = new Color32(211, 211, 211, 255);

        mesh.colors32 = colors;
        mesh.uv = uvs;

        mesh.triangles = new int[] {
            2,0,1,
            2,1,3,

            6,7,5,
            4,6,5,

            9,10,8,
            9,11,10,

            12,14,13,
            14,15,13,

            19,18,17,
            18,16,17,

            21,20,23,
            20,22,23
        };

        mesh.normals = new Vector3[] {
            new Vector3(1.0f , 0.0f, 0.0f),
            new Vector3(1.0f , 0.0f, 0.0f),
            new Vector3(1.0f , 0.0f, 0.0f),
            new Vector3(1.0f , 0.0f, 0.0f),
            
            new Vector3(0.0f , 1.0f, 0.0f),
            new Vector3(0.0f , 1.0f, 0.0f),
            new Vector3(0.0f , 1.0f, 0.0f),
            new Vector3(0.0f , 1.0f, 0.0f),

            new Vector3(0.0f , 0.0f, 1.0f),
            new Vector3(0.0f , 0.0f, 1.0f),
            new Vector3(0.0f , 0.0f, 1.0f),
            new Vector3(0.0f , 0.0f, 1.0f),

            new Vector3(-1.0f , 0.0f, 0.0f),
            new Vector3(-1.0f , 0.0f, 0.0f),
            new Vector3(-1.0f , 0.0f, 0.0f),
            new Vector3(-1.0f , 0.0f, 0.0f),

            new Vector3(0.0f , -1.0f, 0.0f),
            new Vector3(0.0f , -1.0f, 0.0f),
            new Vector3(0.0f , -1.0f, 0.0f),
            new Vector3(0.0f , -1.0f, 0.0f),

            new Vector3(0.0f , 0.0f, -1.0f),
            new Vector3(0.0f , 0.0f, -1.0f),
            new Vector3(0.0f , 0.0f, -1.0f),
            new Vector3(0.0f , 0.0f, -1.0f),
         };
    mesh.RecalculateNormals();
    GetComponent<MeshFilter>().mesh = mesh;
    GetComponent<MeshRenderer>().material = CubeMonitorMaterial;
    }
}