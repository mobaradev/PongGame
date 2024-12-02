using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public bool DestroyOnContact;
    public bool ReduceLiveOnContact;
    public bool IncreaseScoreOnContact;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (this.DestroyOnContact)
            {
                Destroy(collision.gameObject);
            }

            if (this.ReduceLiveOnContact)
            {
                FindObjectOfType<GameManager>().ReduceLives();
            }

            if (this.IncreaseScoreOnContact)
            {
                FindObjectOfType<GameManager>().IncreaseScore();
            }
        }
    }
}
