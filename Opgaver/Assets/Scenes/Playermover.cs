using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermover : MonoBehaviour
{
    public float hastighed = 5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        print("jeg har kaldt en gang");
        print(hastighed);
    }

    // Update is called once per frame
    void Update()
    {
        print("jeg er kaldt meget");
    }
}
