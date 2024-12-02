using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 MaxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * 10f * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * 10f * Time.deltaTime;
        }

        if (this.transform.position.y > MaxY.y)
        {
            this.transform.position = new Vector3(transform.position.x, MaxY.y, transform.position.z);
        }
        
        if (this.transform.position.y < MaxY.x)
        {
            this.transform.position = new Vector3(transform.position.x, MaxY.x, transform.position.z);
        }
    }
}
