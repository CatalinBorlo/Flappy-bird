
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ericscript : MonoBehaviour
{
    public Rigidbody2D skibidi;
    public float putereapasare;
    public Logicscripter logic;
    public bool birdisalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscripter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdisalive == true)
        {
            skibidi.linearVelocity = Vector2.up * putereapasare;
        }
        if(transform.position.y < -30 )
        {
            logic.gameOver();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisalive = false;
    }
}

