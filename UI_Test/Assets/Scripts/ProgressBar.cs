using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBar : MonoBehaviour
{

    public Slider slider;
    public int maxProgress = 10;
    public TextMeshProUGUI progressScore;

    void Start()
    {
        progressScore = GetComponent<TextMeshProUGUI>();
        maxProgress = Random.Range(1, 10);
        SetMaxProgress(maxProgress);
        SetProgress(Random.Range(0, maxProgress));
        progressScore.SetText("{0}/{1}", slider.value, maxProgress);
    }


    public void SetProgress(int progress)
    {
        slider.value = progress;
    }

    public void SetMaxProgress(int progress)
    {
        slider.maxValue = progress;
    
    }
   
}
