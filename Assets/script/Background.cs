using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Vector3 miPosicion;
    public float speed;
    public float limiteizquierdo;
    public static bool fin;
    // Start is called before the first frame update
    void Start()
    {
        miPosicion = transform.position;
        fin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!fin)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= limiteizquierdo) { transform.position = miPosicion; }
        }
        else
        {
            miPosicion.y = 20;
            transform.position = miPosicion;
        }
    }

    public void isend()
    {
        fin = true;
    }
}
