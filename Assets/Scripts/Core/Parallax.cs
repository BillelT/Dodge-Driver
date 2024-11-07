using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    public float scrollSpeedBg = 8.0f;
    public Renderer BackgroundRenderer;
    public GameObject background;

    void Update()
    {

        if (BackgroundRenderer != null)
        {
            BackgroundRenderer.material.mainTextureOffset += new Vector2(0f, scrollSpeed * Time.deltaTime);
        } else
        {
            transform.position -= new Vector3(0f, scrollSpeedBg * Time.deltaTime);
        }

    }
    public void IncreaseParallaxSpeed(float amount)
    {
        scrollSpeed += amount;
        Debug.Log("test");
            
    }
}