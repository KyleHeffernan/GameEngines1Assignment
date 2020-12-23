
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisualizer2 : MonoBehaviour {
    public float scale = 10;

    public float rotSpeed = 200;

    public Material mat;
    List<GameObject> elements = new List<GameObject>();
	// Use this for initialization
	void Start () {
        CreateVisualisers();

    }

    public float radius = 50;

    void CreateVisualisers()
    {
        float theta = (Mathf.PI * 2.0f) / (float) AudioAnalyzer.frameSize;
        for (int i = 0 ; i < AudioAnalyzer.frameSize ; i ++)
        {
            Vector3 pos = new Vector3(
                Mathf.Sin(theta * i) * radius
                , 0
                , Mathf.Cos(theta * i) * radius
                
            );
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.GetComponent<Collider>().enabled = false;
            cube.transform.position = transform.TransformPoint(pos);
            cube.transform.parent = this.transform;
            cube.GetComponent<Renderer>().material = mat;
            elements.Add(cube);
        }
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(AudioAnalyzer.smoothedAmplitude);
        transform.Rotate(0, AudioAnalyzer.smoothedAmplitude * Time.deltaTime * rotSpeed, 0);
        for(int i = 0 ; i < elements.Count ; i ++)
        {
            Vector3 lscale = elements[i].transform.localScale; 
            lscale.y = Mathf.Lerp(lscale.y, 1 + (Mathf.Abs(AudioAnalyzer.wave[i]) * scale), Time.deltaTime * 10);
            elements[i].transform.localScale = lscale;
        }
	}
}
