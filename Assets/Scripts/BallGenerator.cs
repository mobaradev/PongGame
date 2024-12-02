using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject BallPrefab;
    public Vector2 SpawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateBall", 0, 2);
    }

    public void GenerateBall()
    {
        GameObject ball = Instantiate(BallPrefab, SpawnPoint, Quaternion.identity);
    }
    
    


}
