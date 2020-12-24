using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpinner : MonoBehaviour
{
    public float rotSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotating the wheels to look like the car is driving
        transform.Rotate(Time.deltaTime * rotSpeed, 0, 0);
        
        
    }
}
