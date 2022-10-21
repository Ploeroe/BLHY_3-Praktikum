using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKursi : MonoBehaviour
{
[SerializeField]
    public Material CubeKursiMaterial;

    Texture CubeKursiTexture;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var kursi = new Vector3[48];
        var uvs = new Vector2[kursi.Length];

        CubeKursiTexture = Resources.Load<Texture>("Textures/Kursi");

        //Badan Kursi Bagian Belakang
        kursi[0] = new Vector3(2f,0f,2f);
        kursi[1] = new Vector3(2f,-1f,2f);
        kursi[2] = new Vector3(-2f,-1f,2f);
        kursi[3] = new Vector3(-2f,0f,2f);

        uvs[0] = new Vector2(1.0f, 1.0f);
        uvs[1] = new Vector2(1.0f, 0.0f);
        uvs[2] = new Vector2(0.0f, 1.0f);
        uvs[3] = new Vector2(0.0f, 0.0f);

        //Badan Kursi Bagian Depan
        kursi[4] = new Vector3(2f,0f,-2f);
        kursi[5] = new Vector3(2f,-1f,-2f);
        kursi[6] = new Vector3(-2f,-1f,-2f);
        kursi[7] = new Vector3(-2f,0f,-2f);

        uvs[4] = new Vector2(1.0f, 1.0f);
        uvs[5] = new Vector2(1.0f, 0.0f);
        uvs[6] = new Vector2(0.0f, 1.0f);
        uvs[7] = new Vector2(0.0f, 0.0f); 

        //Senderan Kursi Bagian Belakang
        kursi[8] = new Vector3(2f,0f,-2f); // 4
        kursi[9] = new Vector3(2f,2f,-2f);
        kursi[10] = new Vector3(-2f,2f,-2f);
        kursi[11] = new Vector3(-2f,0f,-2f); // 7

        uvs[8] = new Vector2(1.0f, 1.0f);
        uvs[9] = new Vector2(1.0f, 0.0f);
        uvs[10] = new Vector2(0.0f, 1.0f);
        uvs[11] = new Vector2(0.0f, 0.0f);

        //Senderan Kursi Bagian Depan
        kursi[12] = new Vector3(-2f,2f,-1f);
        kursi[13] = new Vector3(-2f,0f,-1f);
        kursi[14] = new Vector3(2f,0f,-1f);
        kursi[15] = new Vector3(2f,2f,-1f);

        uvs[12] = new Vector2(1.0f, 1.0f);
        uvs[13] = new Vector2(1.0f, 0.0f);
        uvs[14] = new Vector2(0.0f, 1.0f);
        uvs[15] = new Vector2(0.0f, 0.0f);

        //Kaki Kursi Bagian Belakang Kiri
        kursi[16] = new Vector3(-2f,-1f,-2f); // 6
        kursi[17] = new Vector3(-2f,-2f,-2f);
        kursi[18] = new Vector3(-1f,-2f,-2f);
        kursi[19] = new Vector3(-1f,-1f,-2f);

        uvs[16] = new Vector2(1.0f, 1.0f);
        uvs[17] = new Vector2(1.0f, 0.0f);
        uvs[18] = new Vector2(0.0f, 1.0f);
        uvs[19] = new Vector2(0.0f, 0.0f);

        kursi[20] = new Vector3(-2f,-1f,-1f);
        kursi[21] = new Vector3(-2f,-2f,-1f);
        kursi[22] = new Vector3(-1f,-2f,-1f);
        kursi[23] = new Vector3(-1f,-1f,-1f);

        uvs[20] = new Vector2(1.0f, 1.0f);
        uvs[21] = new Vector2(1.0f, 0.0f);
        uvs[22] = new Vector2(0.0f, 1.0f);
        uvs[23] = new Vector2(0.0f, 0.0f);

        //Kaki Kursi Bagian Belakang Kanan
        kursi[24] = new Vector3(1f,-1f,-2f);
        kursi[25] = new Vector3(1f,-2f,-2f);
        kursi[26] = new Vector3(2f,-2f,-2f);
        kursi[27] = new Vector3(2f,-1f,-2f);

        uvs[24] = new Vector2(1.0f, 1.0f);
        uvs[25] = new Vector2(1.0f, 0.0f);
        uvs[26] = new Vector2(0.0f, 1.0f);
        uvs[27] = new Vector2(0.0f, 0.0f);

        kursi[28] = new Vector3(1f,-1f,-1f);
        kursi[29] = new Vector3(1f,-2f,-1f);
        kursi[30] = new Vector3(2f,-2f,-1f);
        kursi[31] = new Vector3(2f,-1f,-1f);

        uvs[28] = new Vector2(1.0f, 1.0f);
        uvs[29] = new Vector2(1.0f, 0.0f);
        uvs[30] = new Vector2(0.0f, 1.0f);
        uvs[31] = new Vector2(0.0f, 0.0f);

        //Kaki Kursi Bagian Depan Kiri
        kursi[32] = new Vector3(-2f,-1f,1f);
        kursi[33] = new Vector3(-2f,-2f,1f);
        kursi[34] = new Vector3(-1f,-2f,1f);
        kursi[35] = new Vector3(-1f,-1f,1f);

        uvs[32] = new Vector2(1.0f, 1.0f);
        uvs[33] = new Vector2(1.0f, 0.0f);
        uvs[34] = new Vector2(0.0f, 1.0f);
        uvs[35] = new Vector2(0.0f, 0.0f);

        kursi[36] = new Vector3(-2f,-1f,2f);//2
        kursi[37] = new Vector3(-2f,-2f,2f);
        kursi[38] = new Vector3(-1f,-2f,2f);
        kursi[39] = new Vector3(-1f,-1f,2f);

        uvs[36] = new Vector2(1.0f, 1.0f);
        uvs[37] = new Vector2(1.0f, 0.0f);
        uvs[38] = new Vector2(0.0f, 1.0f);
        uvs[39] = new Vector2(0.0f, 0.0f);

        //Kaki Kursi Bagian Depan Kanan
        kursi[40] = new Vector3(1f,-1f,1f);
        kursi[41] = new Vector3(1f,-2f,1f);
        kursi[42] = new Vector3(2f,-2f,1f);
        kursi[43] = new Vector3(2f,-1f,1f);

        uvs[40] = new Vector2(1.0f, 1.0f);
        uvs[41] = new Vector2(1.0f, 0.0f);
        uvs[42] = new Vector2(0.0f, 1.0f);
        uvs[43] = new Vector2(0.0f, 0.0f);

        kursi[44] = new Vector3(1f,-1f,2f);
        kursi[45] = new Vector3(1f,-2f,2f);
        kursi[46] = new Vector3(2f,-2f,2f);
        kursi[47] = new Vector3(2f,-1f,2f);//1

        uvs[44] = new Vector2(1.0f, 1.0f);
        uvs[45] = new Vector2(1.0f, 0.0f);
        uvs[46] = new Vector2(0.0f, 1.0f);
        uvs[47] = new Vector2(0.0f, 0.0f);

        mesh.vertices = kursi;

        var colors = new Color32[kursi.Length];

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

        colors[40] = new Color32(211, 211, 211, 255);
        colors[41] = new Color32(211, 211, 211, 255);
        colors[42] = new Color32(211, 211, 211, 255);
        colors[43] = new Color32(211, 211, 211, 255);

        colors[44] = new Color32(211, 211, 211, 255);
        colors[45] = new Color32(211, 211, 211, 255);
        colors[46] = new Color32(211, 211, 211, 255);
        colors[47] = new Color32(211, 211, 211, 255);

        mesh.colors32 = colors;
        mesh.uv = uvs;

        mesh.triangles = new int[]{
            2, 1, 0,
            3, 2, 0,
            3, 0, 4,
            4, 7, 3,
            3, 6, 2,
            3, 7, 6,
            6, 5, 2,
            5, 1, 2,
            5, 6, 4,
            6, 7, 4,
            1, 5, 4,
            4, 0, 1,

            8,11,9,
            11,10,9,
            11,13,10,
            13,12,10,
            13,14,12,
            14,15,12,
            14,8,15,
            8,9,15,
            9,10,15,
            10,12,15,
            14,13,8,
            13,11,8,

            18,17,19,
            17,16,19,
            17,21,16,
            21,20,16,
            21,22,20,
            22,23,20,
            22,18,23,
            18,19,23,
            22,21,18,
            21,17,18,
            19,16,23,
            16,20,23,

            26,25,27,
            25,24,27,
            25,29,24,
            29,28,24,
            29,30,28,
            30,31,28,
            30,26,31,
            26,27,31,
            30,29,26,
            29,25,26,
            27,24,31,
            24,28,31,

            34,33,35,
            33,32,35,
            33,37,32,
            37,36,32,
            37,38,36,
            38,39,36,
            38,34,39,
            34,35,39,
            38,37,34,
            37,33,34,
            35,32,39,
            32,36,39,

            42,41,43,
            41,40,43,
            41,45,40,
            45,44,40,
            45,46,44,
            46,47,44,
            46,42,47,
            42,43,47,
            46,45,42,
            45,41,42,
            43,40,47,
            40,44,47
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = CubeKursiMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}