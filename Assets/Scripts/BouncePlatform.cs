using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlatform : MonoBehaviour
{
    [SerializeField] [Range(100f, 600f)]float bounceForce = 600f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0.2)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 600);
        }
    }
}
