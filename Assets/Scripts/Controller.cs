using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rig2D;
    private float moveInput;
    [Tooltip("This is to adjust how fast the player will be travelling to the side")]
    [SerializeField] [Range(1.0f, 10.0f)] float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rig2D.velocity = new Vector2(moveInput * speed, rig2D.velocity.y);
    }
}
