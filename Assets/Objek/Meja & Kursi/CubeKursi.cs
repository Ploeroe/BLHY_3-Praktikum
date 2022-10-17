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
        var kursiMain = new Vector3[46];

        //Badan Kursi Bagian Belakang
        kursiMain[0] = new Vector3(2f,0f,2f);
        kursiMain[1] = new Vector3(2f,-1f,2f);
        kursiMain[2] = new Vector3(-2f,-1f,2f);
        kursiMain[3] = new Vector3(-2f,0f,2f);

        //Badan Kursi Bagian Depan
        kursiMain[4] = new Vector3(2f,0f,-2f);
        kursiMain[5] = new Vector3(2f,-1f,-2f);
        kursiMain[6] = new Vector3(-2f,-1f,-2f);
        kursiMain[7] = new Vector3(-2f,0f,-2f);
    
        //Senderan Kursi Bagian Belakang
        kursiMain[8] = new Vector3(-2f,2f,-2f);
        kursiMain[9] = new Vector3(2f,2f,-2f);

        //Senderan Kursi Bagian Depan
        kursiMain[10] = new Vector3(-2f,2f,-1f);
        kursiMain[11] = new Vector3(-2f,0f,-1f);
        kursiMain[12] = new Vector3(2f,0f,-1f);
        kursiMain[13] = new Vector3(2f,2f,-1f);

        //Kaki Kursi Bagian Belakang Kiri
        // kursiMain[14] = new Vector3(-2f,-1f,-2f);//6
        kursiMain[14] = new Vector3(-2f,-2f,-2f);
        kursiMain[15] = new Vector3(-1f,-2f,-2f);
        kursiMain[16] = new Vector3(-1f,-1f,-2f);

        kursiMain[17] = new Vector3(-2f,-1f,-1f);
        kursiMain[18] = new Vector3(-2f,-2f,-1f);
        kursiMain[19] = new Vector3(-1f,-2f,-1f);
        kursiMain[20] = new Vector3(-1f,-1f,-1f);


        //Kaki Kursi Bagian Belakang Kanan
        kursiMain[21] = new Vector3(1f,-1f,-2f);
        kursiMain[22] = new Vector3(1f,-2f,-2f);
        kursiMain[23] = new Vector3(2f,-2f,-2f);
        // kursiMain[25] = new Vector3(2f,-1f,-2f);//5

        kursiMain[24] = new Vector3(1f,-1f,-1f);
        kursiMain[25] = new Vector3(1f,-2f,-1f);
        kursiMain[26] = new Vector3(2f,-2f,-1f);
        kursiMain[27] = new Vector3(2f,-1f,-1f);

        //Kaki Kursi Bagian Depan Kiri

        kursiMain[28] = new Vector3(-2f,-1f,1f);
        kursiMain[29] = new Vector3(-2f,-2f,1f);
        kursiMain[30] = new Vector3(-1f,-2f,1f);
        kursiMain[31] = new Vector3(-1f,-1f,1f);

        // kursiMain[34] = new Vector3(-2f,-1f,2f);2
        kursiMain[32] = new Vector3(-2f,-2f,2f);
        kursiMain[33] = new Vector3(-1f,-2f,2f);
        kursiMain[34] = new Vector3(-1f,-1f,2f);

        //Kaki Kursi Bagian Depan Kanan

        kursiMain[35] = new Vector3(1f,-1f,1f);
        kursiMain[36] = new Vector3(1f,-2f,1f);
        kursiMain[37] = new Vector3(2f,-2f,1f);
        kursiMain[38] = new Vector3(2f,-1f,1f);

        kursiMain[39] = new Vector3(1f,-1f,2f);
        kursiMain[40] = new Vector3(1f,-2f,2f);
        kursiMain[41] = new Vector3(2f,-2f,2f);
        // kursiMain[45] = new Vector3(2f,-1f,2f);//1

        mesh.vertices = kursiMain;

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

            4,7,9,
            7,8,9,
            7,11,8,
            11,10,8,
            11,12,10,
            12,13,10,
            12,4,13,
            4,9,13,
            9,8,13,
            8,10,13,

            15,14,16,
            14,6,16,
            14,18,6,
            18,17,6,
            18,19,17,
            19,20,17,
            19,15,20,
            15,16,20,
            19,18,15,
            18,14,15,

            23,22,5,
            22,21,5,
            22,25,21,
            25,24,21,
            25,26,24,
            26,27,24,
            26,23,27,
            23,5,27,
            26,25,23,
            25,22,23,

            30,29,31,
            29,28,31,
            29,32,28,
            32,2,28,
            32,33,2,
            33,34,2,
            33,30,34,
            30,31,34,
            33,32,30,
            32,29,30,

            37,36,38,
            36,35,38,
            36,40,35,
            40,39,35,
            40,41,39,
            41,1,39,
            41,37,1,
            37,38,1,
            41,40,37,
            40,36,37,

        };
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = cubeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}