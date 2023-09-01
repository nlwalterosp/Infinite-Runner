using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leyenda : MonoBehaviour
{
    public Vector3 miPosicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Background.fin) { miPosicion.x = -3; miPosicion.y = -3; transform.position = miPosicion; }
        
    }
}
