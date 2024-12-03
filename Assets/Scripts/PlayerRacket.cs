using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRacket : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 5f, ForceMode2D.Impulse);
        }
    }
}
