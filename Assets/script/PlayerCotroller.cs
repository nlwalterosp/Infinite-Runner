using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCotroller : MonoBehaviour
{
    public Rigidbody2D rigibody;
    public float forceJump=10f;
    public bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(isGround && Input.GetKeyDown(KeyCode.Space)) { rigibody.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse); }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("GROUND")) { isGround = true; }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("GROUND")) { isGround = false; }
    }
}
