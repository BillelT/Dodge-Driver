using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTime : MonoBehaviour
{
    public TextMeshProUGUI ScoreTimeText;
    private float scoreTime;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            scoreTime += 1 * Time.deltaTime;
            ScoreTimeText.text = scoreTime.ToString("0.00") + "s";
        }
    }
}

