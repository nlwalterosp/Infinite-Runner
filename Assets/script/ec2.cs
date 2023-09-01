using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ec2 : MonoBehaviour
{
    public float speed;
    public Vector3 miPosicion;
    int a;

    // Start is called before the first frame update
    void Start()
    {
        a = 1;
    }

    // Update is called once per frame
    void Update()
    {

        miPosicion.x = 10;
        miPosicion.y = 2;
        ///if (a%2==0)miPosicion.y = 2;
        //else miPosicion.y = 5;
        ///a++;
        ///// transform.Translate(Vector3.left * speed * Time.deltaTime);
        //// transform.position = miPosicion;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Player")) { Time.timeScale = 0; }

    }
}
