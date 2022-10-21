using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMeja : MonoBehaviour
{
[SerializeField]
    public Material CubeMejaMaterial;

    Texture CubeMejaTexture;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var meja = new Vector3[46];
        var uvs = new Vector2[meja.Length];

        CubeMejaTexture = Resources.Load<Texture>("Textures/Meja");

        //Badan Meja
        meja[0] = new Vector3(2f,1f,2f);
        meja[1] = new Vector3(2f,0f,2f);
        meja[2] = new Vector3(-2f,0f,2f);
        meja[3] = new Vector3(-2f,1f,2f);

        uvs[0] = new Vector2(1.0f, 1.0f);
        uvs[1] = new Vector2(1.0f, 0.0f);
        uvs[2] = new Vector2(0.0f, 1.0f);
        uvs[3] = new Vector2(0.0f, 0.0f);

        meja[4] = new Vector3(2f,1f,-2f);
        meja[5] = new Vector3(2f,0f,-2f);
        meja[6] = new Vector3(-2f,0f,-2f);
        meja[7] = new Vector3(-2f,1f,-2f);

        uvs[4] = new Vector2(1.0f, 1.0f);
        uvs[5] = new Vector2(1.0f, 0.0f);
        uvs[6] = new Vector2(0.0f, 1.0f);
        uvs[7] = new Vector2(0.0f, 0.0f); 

        //Kaki Meja Bagian Belakang Kiri
        meja[8] = new Vector3(-2f,0f,-2f);
        meja[9] = new Vector3(-2f,-2f,-2f);
        meja[10] = new Vector3(-1f,-2f,-2f);
        meja[11] = new Vector3(-1f,0f,-2f);

        uvs[8] = new Vector2(1.0f, 1.0f);
        uvs[9] = new Vector2(1.0f, 0.0f);
        uvs[10] = new Vector2(0.0f, 1.0f);
        uvs[11] = new Vector2(0.0f, 0.0f);

        meja[12] = new Vector3(-2f,0f,-1f);
        meja[13] = new Vector3(-2f,-2f,-1f);
        meja[14] = new Vector3(-1f,-2f,-1f);
        meja[15] = new Vector3(-1f,0f,-1f);

        uvs[12] = new Vector2(1.0f, 1.0f);
        uvs[13] = new Vector2(1.0f, 0.0f);
        uvs[14] = new Vector2(0.0f, 1.0f);
        uvs[15] = new Vector2(0.0f, 0.0f);

        //Kaki Meja Bagian Belakang Kanan
        meja[16] = new Vector3(1f,0f,-2f);
        meja[17] = new Vector3(1f,-2f,-2f);
        meja[18] = new Vector3(2f,-2f,-2f);
        meja[19] = new Vector3(2f,0f,-2f);

        uvs[16] = new Vector2(1.0f, 1.0f);
        uvs[17] = new Vector2(1.0f, 0.0f);
        uvs[18] = new Vector2(0.0f, 1.0f);
        uvs[19] = new Vector2(0.0f, 0.0f);

        meja[20] = new Vector3(1f,0f,-1f);
        meja[21] = new Vector3(1f,-2f,-1f);
        meja[22] = new Vector3(2f,-2f,-1f);
        meja[23] = new Vector3(2f,0f,-1f);

        uvs[20] = new Vector2(1.0f, 1.0f);
        uvs[21] = new Vector2(1.0f, 0.0f);
        uvs[22] = new Vector2(0.0f, 1.0f);
        uvs[23] = new Vector2(0.0f, 0.0f);

        //Kaki Meja Bagian Depan Kiri
        meja[24] = new Vector3(-2f,0f,1f);
        meja[25] = new Vector3(-2f,-2f,1f);
        meja[26] = new Vector3(-1f,-2f,1f);
        meja[27] = new Vector3(-1f,0f,1f);

        uvs[24] = new Vector2(1.0f, 1.0f);
        uvs[25] = new Vector2(1.0f, 0.0f);
        uvs[26] = new Vector2(0.0f, 1.0f);
        uvs[27] = new Vector2(0.0f, 0.0f);

        meja[28] = new Vector3(-2f,0f,2f);
        meja[29] = new Vector3(-2f,-2f,2f);
        meja[30] = new Vector3(-1f,-2f,2f);
        meja[31] = new Vector3(-1f,0f,2f);

        uvs[28] = new Vector2(1.0f, 1.0f);
        uvs[29] = new Vector2(1.0f, 0.0f);
        uvs[30] = new Vector2(0.0f, 1.0f);
        uvs[31] = new Vector2(0.0f, 0.0f);

        //Kaki Meja Bagian Depan Kanan
        meja[32] = new Vector3(1f,0f,1f);
        meja[33] = new Vector3(1f,-2f,1f);
        meja[34] = new Vector3(2f,-2f,1f);
        meja[35] = new Vector3(2f,0f,1f);

        uvs[32] = new Vector2(1.0f, 1.0f);
        uvs[33] = new Vector2(1.0f, 0.0f);
        uvs[34] = new Vector2(0.0f, 1.0f);
        uvs[35] = new Vector2(0.0f, 0.0f);

        meja[36] = new Vector3(1f,0f,2f);
        meja[37] = new Vector3(1f,-2f,2f);
        meja[38] = new Vector3(2f,-2f,2f);
        meja[39] = new Vector3(2f,0f,2f);

        uvs[36] = new Vector2(1.0f, 1.0f);
        uvs[37] = new Vector2(1.0f, 0.0f);
        uvs[38] = new Vector2(0.0f, 1.0f);
        uvs[39] = new Vector2(0.0f, 0.0f);

        mesh.vertices = meja;

        var colors = new Color32[meja.Length];

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

        colors[24] = new Color32(211, 211, 211, 255);
        colors[25] = new Color32(211, 211, 211, 255);
        colors[26] = new Color32(211, 211, 211, 255);
        colors[27] = new Color32(211, 211, 211, 255);

        colors[28] = new Color32(211, 211, 211, 255);
        colors[29] = new Color32(211, 211, 211, 255);
        colors[30] = new Color32(211, 211, 211, 255);
        colors[31] = new Color32(211, 211, 211, 255);

        colors[32] = new Color32(211, 211, 211, 255);
        colors[33] = new Color32(211, 211, 211, 255);
        colors[34] = new Color32(211, 211, 211, 255);
        colors[35] = new Color32(211, 211, 211, 255);

        colors[36] = new Color32(211, 211, 211, 255);
        colors[37] = new Color32(211, 211, 211, 255);
        colors[38] = new Color32(211, 211, 211, 255);
        colors[39] = new Color32(211, 211, 211, 255);

        mesh.colors32 = colors;
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
            4, 0, 1,  //Sixth Face

            38,34,39,
            34,35,39,
            34,33,35,
            33,32,35,
            33,37,32,
            37,36,32,
            37,38,36,
            38,39,36,
            33,34,37,
            34,38,37,

            29,30,28,
            30,31,28,
            25,29,24,
            29,28,24,
            26,25,27,
            25,24,27,
            30,26,31,
            26,27,31,
            25,26,29,
            26,30,29,

            21,22,20,
            22,23,20,
            17,21,16,
            21,20,16,
            18,17,19,
            17,16,19,
            22,18,23,
            18,19,23,
            17,18,21,
            18,22,21,

            13,14,12,
            14,15,12,
            9,13,8,
            13,12,8,
            10,9,11,
            9,8,11,
            14,10,15,
            10,11,15,
            9,10,13,
            10,14,13,
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = CubeMejaMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
