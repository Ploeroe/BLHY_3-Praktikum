using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKursi : MonoBehaviour
{
[SerializeField]
    public Material cubeMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var kursi = new Vector3[48];

        //Badan Kursi Bagian Belakang
        kursi[0] = new Vector3(2f,0f,2f);
        kursi[1] = new Vector3(2f,-1f,2f);
        kursi[2] = new Vector3(-2f,-1f,2f);
        kursi[3] = new Vector3(-2f,0f,2f);

        //Badan Kursi Bagian Depan
        kursi[4] = new Vector3(2f,0f,-2f);
        kursi[5] = new Vector3(2f,-1f,-2f);
        kursi[6] = new Vector3(-2f,-1f,-2f);
        kursi[7] = new Vector3(-2f,0f,-2f);
    
        //Senderan Kursi Bagian Belakang
        kursi[8] = new Vector3(2f,0f,-2f); // 4
        kursi[9] = new Vector3(2f,2f,-2f);
        kursi[10] = new Vector3(-2f,2f,-2f);
        kursi[11] = new Vector3(-2f,0f,-2f); // 7

        //Senderan Kursi Bagian Depan
        kursi[12] = new Vector3(-2f,2f,-1f);
        kursi[13] = new Vector3(-2f,0f,-1f);
        kursi[14] = new Vector3(2f,0f,-1f);
        kursi[15] = new Vector3(2f,2f,-1f);

        //Kaki Kursi Bagian Belakang Kiri
        kursi[16] = new Vector3(-2f,-1f,-2f); // 6
        kursi[17] = new Vector3(-2f,-2f,-2f);
        kursi[18] = new Vector3(-1f,-2f,-2f);
        kursi[19] = new Vector3(-1f,-1f,-2f);

        kursi[20] = new Vector3(-2f,-1f,-1f);
        kursi[21] = new Vector3(-2f,-2f,-1f);
        kursi[22] = new Vector3(-1f,-2f,-1f);
        kursi[23] = new Vector3(-1f,-1f,-1f);

        //Kaki Kursi Bagian Belakang Kanan
        kursi[24] = new Vector3(1f,-1f,-2f);
        kursi[25] = new Vector3(1f,-2f,-2f);
        kursi[26] = new Vector3(2f,-2f,-2f);
        kursi[27] = new Vector3(2f,-1f,-2f);

        kursi[28] = new Vector3(1f,-1f,-1f);
        kursi[29] = new Vector3(1f,-2f,-1f);
        kursi[30] = new Vector3(2f,-2f,-1f);
        kursi[31] = new Vector3(2f,-1f,-1f);

        //Kaki Kursi Bagian Depan Kiri
        kursi[32] = new Vector3(-2f,-1f,1f);
        kursi[33] = new Vector3(-2f,-2f,1f);
        kursi[34] = new Vector3(-1f,-2f,1f);
        kursi[35] = new Vector3(-1f,-1f,1f);

        kursi[36] = new Vector3(-2f,-1f,2f);//2
        kursi[37] = new Vector3(-2f,-2f,2f);
        kursi[38] = new Vector3(-1f,-2f,2f);
        kursi[39] = new Vector3(-1f,-1f,2f);

        //Kaki Kursi Bagian Depan Kanan
        kursi[40] = new Vector3(1f,-1f,1f);
        kursi[41] = new Vector3(1f,-2f,1f);
        kursi[42] = new Vector3(2f,-2f,1f);
        kursi[43] = new Vector3(2f,-1f,1f);

        kursi[44] = new Vector3(1f,-1f,2f);
        kursi[45] = new Vector3(1f,-2f,2f);
        kursi[46] = new Vector3(2f,-2f,2f);
        kursi[47] = new Vector3(2f,-1f,2f);//1

        mesh.vertices = kursi;

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
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = cubeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}