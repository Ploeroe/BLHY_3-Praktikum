using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMeja : MonoBehaviour
{
[SerializeField]
    public Material cubeMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        var meja = new Vector3[46];

        //Badan Meja
        meja[0] = new Vector3(2f,1f,2f);
        meja[1] = new Vector3(2f,0f,2f);
        meja[2] = new Vector3(-2f,0f,2f);
        meja[3] = new Vector3(-2f,1f,2f);

        meja[4] = new Vector3(2f,1f,-2f);
        meja[5] = new Vector3(2f,0f,-2f);
        meja[6] = new Vector3(-2f,0f,-2f);
        meja[7] = new Vector3(-2f,1f,-2f);
        
        //Kaki Meja Bagian Belakang Kiri
        meja[8] = new Vector3(-2f,0f,-2f);
        meja[9] = new Vector3(-2f,-2f,-2f);
        meja[10] = new Vector3(-1f,-2f,-2f);
        meja[11] = new Vector3(-1f,0f,-2f);

        meja[12] = new Vector3(-2f,0f,-1f);
        meja[13] = new Vector3(-2f,-2f,-1f);
        meja[14] = new Vector3(-1f,-2f,-1f);
        meja[15] = new Vector3(-1f,0f,-1f);

        //Kaki Meja Bagian Belakang Kanan
        meja[16] = new Vector3(1f,0f,-2f);
        meja[17] = new Vector3(1f,-2f,-2f);
        meja[18] = new Vector3(2f,-2f,-2f);
        meja[19] = new Vector3(2f,0f,-2f);

        meja[20] = new Vector3(1f,0f,-1f);
        meja[21] = new Vector3(1f,-2f,-1f);
        meja[22] = new Vector3(2f,-2f,-1f);
        meja[23] = new Vector3(2f,0f,-1f);

        //Kaki Meja Bagian Depan Kiri
        meja[24] = new Vector3(-2f,0f,1f);
        meja[25] = new Vector3(-2f,-2f,1f);
        meja[26] = new Vector3(-1f,-2f,1f);
        meja[27] = new Vector3(-1f,0f,1f);
        
        meja[28] = new Vector3(-2f,0f,2f);
        meja[29] = new Vector3(-2f,-2f,2f);
        meja[30] = new Vector3(-1f,-2f,2f);
        meja[31] = new Vector3(-1f,0f,2f);

        //Kaki Meja Bagian Depan Kanan
        meja[32] = new Vector3(1f,0f,1f);
        meja[33] = new Vector3(1f,-2f,1f);
        meja[34] = new Vector3(2f,-2f,1f);
        meja[35] = new Vector3(2f,0f,1f);

        meja[36] = new Vector3(1f,0f,2f);
        meja[37] = new Vector3(1f,-2f,2f);
        meja[38] = new Vector3(2f,-2f,2f);
        meja[39] = new Vector3(2f,0f,2f);

        mesh.vertices = meja;

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
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = cubeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
