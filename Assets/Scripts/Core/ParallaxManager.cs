using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackgroundManager : MonoBehaviour
{
    public Parallax[] parallaxBackgrounds;


    public void IncreaseParallaxSpeed(float amount)
    {
        foreach (Parallax background in parallaxBackgrounds)
        {
            background.IncreaseParallaxSpeed(amount);
            Debug.Log("test");
        }
    }
}