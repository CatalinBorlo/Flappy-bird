using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipemiddlescript : MonoBehaviour
{
    public Logicscripter logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscripter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
