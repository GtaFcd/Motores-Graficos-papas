using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    public int minInten;
    public int maxInten;
    public float velocidad;

    private Light luz;


    void Start()
    {
        luz = GetComponent<Light>();
    }

   
    void Update()
    {
        luz.intensity = Mathf.Lerp(minInten, maxInten, Mathf.PingPong(Time.time, velocidad));
    }
}
