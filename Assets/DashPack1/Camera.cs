using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rgb;
     void Start()
    {
        
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rgb.velocity = new Vector2(speed, 0);
        
    }
}
