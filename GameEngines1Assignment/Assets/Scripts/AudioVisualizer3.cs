using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisualizer3 : MonoBehaviour
{
    // Each building in the terrain is set to have a band from 0 - 8
    public int band = 1;
    public float scale = 10;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
        this.transform.parent = this.transform;
    }


    // Update is called once per frame
    void Update () {
        // This makes the buildings reactive to audio. It scales their y value to the current size of their respective audio band
        Vector3 ls = transform.localScale;
        ls.y = Mathf.Lerp(ls.y, 1 + (AudioAnalyzer.bands[band] * scale), Time.deltaTime * 3.0f);
        transform.localScale = ls;
        Vector3 pos = transform.position;
        transform.position = pos;

	}
}
