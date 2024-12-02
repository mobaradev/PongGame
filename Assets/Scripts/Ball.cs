using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().AddForce((Vector2.up * Random.Range(-100f, 100f) * 3) + (Vector2.right * Random.Range(25f, 100f) * 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
