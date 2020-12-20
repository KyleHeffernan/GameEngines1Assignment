using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisualizer3 : MonoBehaviour
{
    public int band = 1;
    public float scale = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update () {
       
        Vector3 ls = transform.localScale;
        ls.y = Mathf.Lerp(ls.y, 1 + (AudioAnalyzer.bands[band] * scale), Time.deltaTime * 3.0f);
        transform.localScale = ls;

	}
}
