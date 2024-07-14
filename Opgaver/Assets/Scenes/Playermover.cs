using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Playermover : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    public Animator animator;
    public GameObject gameOverScreen;
    public float Liv = 3f;
    public TextMeshProUGUI LivTekst;
    
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("test");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
            if (Liv <= 0)
            {
                gameOverScreen.SetActive(true);
                Destroy(gameObject);
            }
            else
            {
                Liv -= 1;
                LivTekst.text = "Liv: " + Liv.ToString() + "/3";
                
            }
    }
    
}


