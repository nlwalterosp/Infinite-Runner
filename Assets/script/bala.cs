using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{

    Vector3 miPosicion;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {

        miPosicion.x = -25; miPosicion.y = 2; miPosicion.z = 0;


    }

    // Update is called once per frame

    void Update()
    {
        transform.Translate(speed, 0, 0);
       if (transform.position.x > 10) { if (2 < Random.Range(1, 100)) { miPosicion.y = Random.Range(-2, 4); transform.position = miPosicion; } }

    }
    
}
