using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour
{
    public float BulletDestroyCD = 2f;

    private float remainingBulletCD = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingBulletCD = remainingBulletCD - Time.deltaTime;
        if (remainingBulletCD <= 0)
        {
            Destroy(gameObject);
            remainingBulletCD = BulletDestroyCD;
        }
    }
}
