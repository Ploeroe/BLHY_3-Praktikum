using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotBawah : MonoBehaviour
{
    public float rotateSpeed = 10f;
    float xangle;
    float zangle;
    void Start()
    {
        float xangle = transform.rotation.x;
        float zangle = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(xangle, Time.deltaTime*rotateSpeed, Time.deltaTime*rotateSpeed));
    }
}
