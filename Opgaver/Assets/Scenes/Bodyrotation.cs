using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;

public class Bodyrotation : MonoBehaviour
{
    public GameObject Bulletprefab;

    public float CooldownTime = 0.3f;

    private float remainingCooldown;
    public float BulletSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float TurnaroundInput = Input.GetAxisRaw("Turnaround");
        transform.Rotate(0, TurnaroundInput, 0);
        remainingCooldown = remainingCooldown - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)&& remainingCooldown <= 0) 
        {
            GameObject bullet = Instantiate(Bulletprefab, transform.position, Quaternion.identity);
            Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
            bulletRB.velocity = transform.forward * BulletSpeed;
            remainingCooldown = CooldownTime;
        }
    }
}
