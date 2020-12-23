using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suspension : MonoBehaviour
{
    // speed at which car bounces
    public float speed = 1f;
    // adjust to change how high it goes   
    public float height = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {
            Vector3 pos = this.transform.position;
            //calculate what the new Y position will be
            float newY = Mathf.Sin(Time.time * speed);
            //set the object's Y to the new calculated Y
            newY = newY + 4;
            newY = (newY * height);
            transform.position = new Vector3(pos.x, newY, pos.z);
    }
}
