
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class HueScript : MonoBehaviour
{
    // The rate at which hue changes
    public float colorShift = 0.01f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Accessing the hue from colorgrading
        var volume = this.GetComponent<PostProcessVolume>();

        if (volume.profile.TryGetSettings<ColorGrading>(out var ColorGrading))
        {
            //If it reaches the max, reset it to minimum
            if(ColorGrading.hueShift.value == 180)
            {
                ColorGrading.hueShift.value = -180;
            }
            else
            {
                ColorGrading.hueShift.value += (float)colorShift;
                //If amptitude gets very high, change hue much faster
                if(AudioAnalyzer.smoothedAmplitude > .3)
                {
                    ColorGrading.hueShift.value += .8f;
                }
            }

        }
        
    }
    
}

 
