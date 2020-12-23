
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class HueScript : MonoBehaviour
{
    public float colorShift = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var volume = this.GetComponent<PostProcessVolume>();

        if (volume.profile.TryGetSettings<ColorGrading>(out var ColorGrading))
        {
            if(ColorGrading.hueShift.value == 180)
            {
                ColorGrading.hueShift.value = 1;
            }
            else
            {
                ColorGrading.hueShift.value += (float)colorShift;
            }

        }
        
    }
    
}

 
