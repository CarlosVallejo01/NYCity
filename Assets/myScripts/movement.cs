using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = -1F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(0, 0, speed);
    }
}