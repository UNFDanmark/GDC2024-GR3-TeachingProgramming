using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermover : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = rb.velocity;
        movement.x = Input.GetAxisRaw("Horizontal") * speed;
        movement.z = Input.GetAxisRaw("Vertical") * speed;
        rb.velocity = movement;
        
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }
}
