
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

    //System.Collections.IEnumerator HueShift()
    //{
   //     yield return new WaitForSeconds(10);
    //}

    // Update is called once per frame
    void Update()
    {
        var volume = this.GetComponent<PostProcessVolume>();

        if (volume.profile.TryGetSettings<ColorGrading>(out var ColorGrading))
        {
            if(ColorGrading.hueShift.value == 180)
            {
                ColorGrading.hueShift.value = -180;
            }
            else
            {
                ColorGrading.hueShift.value += (float)colorShift;
                if(AudioAnalyzer.smoothedAmplitude > .3)
                {
                    ColorGrading.hueShift.value += 1;
                }
            }

        }
        
    }
    
}

 
