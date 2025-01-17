using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Spawn Ranges")]
    public float xRange;
    public float zRange;

    [Header("Prefabs")]
    public GameObject[] Target;

    [Header("Ints")]
    public int enemyCount;
    public int waveNumber = 1;

    [Header("GameManager")]
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
