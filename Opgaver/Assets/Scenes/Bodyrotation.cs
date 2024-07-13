using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;

public class Bodyrotation : MonoBehaviour
{
    public GameObject Bulletprefab;

    public float CooldownTime = 0.3f;

    private float remainingCooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float TurnaroundInput = Input.GetAxis("Turnaround");
        transform.Rotate(0, TurnaroundInput, 0);
        remainingCooldown = remainingCooldown - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)&& remainingCooldown <= 0) 
        {
            Instantiate(Bulletprefab, transform.position, Quaternion.identity);
            remainingCooldown = CooldownTime;
        }
    }
}
