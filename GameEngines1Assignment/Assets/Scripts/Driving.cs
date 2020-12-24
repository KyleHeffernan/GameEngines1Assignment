using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour
{

    public float speed = 1f;

    // Adjust to change how far it strafes   
    public float strafe = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            Vector3 pos = this.transform.position;
            //calculate what the new X position will be
            float newX = Mathf.Sin(Time.time * speed);
            //set the object's X to the new calculated X
            newX = newX - 8; // offset
            newX = (newX * strafe);
            transform.position = new Vector3(newX, pos.y, pos.z);
    }
}