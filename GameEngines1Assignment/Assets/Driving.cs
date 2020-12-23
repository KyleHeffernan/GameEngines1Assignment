using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour
{

    public float speed = 1f;
    //adjust this to change how high it goes   
    public float strafe = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {
            Vector3 pos = this.transform.position;
            //calculate what the new Y position will be
            float newX = Mathf.Sin(Time.time * speed);
            //set the object's Y to the new calculated Y
            newX = newX - 8;
            newX = (newX * strafe);
            transform.position = new Vector3(newX, pos.y, pos.z);
    }
}