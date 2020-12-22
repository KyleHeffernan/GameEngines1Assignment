using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suspension : MonoBehaviour
{

    public float speed = 1f;
    //adjust this to change how high it goes   
    public float height = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
            Vector3 pos = transform.position;
            //calculate what the new Y position will be
            float newY = Mathf.Sin(Time.time * speed);
            //set the object's Y to the new calculated Y
            transform.position = new Vector3(pos.x, newY, pos.z) * height;
    }
}
