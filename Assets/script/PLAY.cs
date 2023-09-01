using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PLAY : MonoBehaviour
{

    public float speed, speedx;
    float ta0;
    bool gu, gd, gr, gl, cold,bta0;
    public static bool live;
    public int nn,nv;
    public TMP_Text txc,txm;
    // Start is called before the first frame update
    void Start()
    {
       gu = false; gd = false; gr = false; gl = false; cold = false;live = true;nn = 0;bta0 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bta0 && 3<Time.time-ta0) { bta0 = false; GetComponent<Animator>().Play("volar"); } 
        if (gu) transform.Translate(0, speed, 0);
        if (gd) transform.Translate(0, -speed, 0);
        if (gr) transform.Translate(speedx, 0, 0);
        if (gl) transform.Translate(-speedx, 0, 0);
        if (live)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                gu = true;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                gu = false;
            }
            if (!cold && Input.GetKeyDown(KeyCode.DownArrow))
            {
                gd = true;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                gd = false;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gr = true;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                gr = false;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gl = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                gl = false;
            }
        }            
    }


   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("piso")) { gd = false; cold = true; }
        if (collision.gameObject.CompareTag("bala")) {
            nv--;if (1 > nv)
            {
                live = false;
                GetComponent<Animator>().Play("die");
               /// Background.Instance.end = false;
               ///     isend();
            }
            txm.SetText("" + nv);
        }
        if (collision.gameObject.CompareTag("nota"))
        {
            nn++;
            ////txc = GetComponent<TMP_Text>();
            txc.SetText(""+nn);
           /////GetComponent<Animator>().Play("power");


        }
        if (collision.gameObject.CompareTag("live"))
        {
            nv++;
            ////txc = GetComponent<TMP_Text>();
            ////txc.SetText("" + nv);
            GetComponent<Animator>().Play("power");
            ta0 = Time.time;
            bta0 = true;
            txm.SetText("" + nv);


        }

    }

     void OnTriggerStay2D(Collider2D collision)
    {
        


    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("piso")) {  cold = false; }

    }
}
