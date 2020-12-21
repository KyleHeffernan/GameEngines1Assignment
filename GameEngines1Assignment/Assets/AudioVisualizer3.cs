using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisualizer3 : MonoBehaviour
{
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
       
        Vector3 ls = transform.localScale;
        ls.y = Mathf.Lerp(ls.y, 1 + (AudioAnalyzer.bands[band] * scale), Time.deltaTime * 3.0f);
        transform.localScale = ls;
        Vector3 pos = transform.position;
        Debug.Log(ls.y + "InCorrect one");
        pos.y = 0 + (ls.y / 2);
        transform.position = pos;

	}
}
