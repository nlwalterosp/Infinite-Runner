using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lucky : MonoBehaviour
{

    Vector3 miPosicion;

    // Start is called before the first frame update
    void Start()
    {
        miPosicion.x = 0; miPosicion.y = 100; miPosicion.z = 0;
    }


    void Update()
    {
        transform.Translate((float)-0.01,0,0);
        if (transform.position.x <= -10) { miPosicion.x = Random.Range(-7, 7); miPosicion.y = Random.Range(-2, 4); transform.position = miPosicion; }
    }
    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { miPosicion.x = Random.Range(-7,7); miPosicion.y = Random.Range(-2, 4); transform.position = miPosicion; }

    }
 
}
