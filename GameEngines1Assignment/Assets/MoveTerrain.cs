using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTerrain : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 30);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= transform.forward * speed * Time.deltaTime;
    }
}
