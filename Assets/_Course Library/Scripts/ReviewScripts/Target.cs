using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [Header("Ints")]
    public int hp;

    [Header("Components")]
    public Rigidbody rb;

    [Header("Scripts")]
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        //getting the components
        rb = GetComponent<Rigidbody>();

        //getting the gameObjects and their scripts
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
