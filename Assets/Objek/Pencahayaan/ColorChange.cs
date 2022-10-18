using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{   float duration = 1.0f;
    Color color0 = Color.red;
    Color color1 = Color.blue;

    Light lt;
    // Start is called before the first frame update
    void Start()
    {
         lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        lt.color = Color.Lerp(color0, color1, t);
    }
}
