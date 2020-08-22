using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncreseButton : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI donutsCounter;
    public RectTransform donutRect;
    public GameObject picture;

   
    void Start()
    {
        donutsCounter = GetComponent<TextMeshProUGUI>();
        score = 0;
       donutRect= picture.GetComponent<RectTransform>();
    }
    
    void Update()
    {
     
        donutsCounter.SetText("{0}", score);
    }


    private IEnumerator Pulse()
    {
        for (float i=1f; i<=1.2f; i += 0.05f)
        {
            donutRect.localScale = new Vector3(i, i, i);
            donutsCounter.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForEndOfFrame();
        }
        donutRect.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        donutsCounter.rectTransform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        score += 1;
        for (float i = 1f; i >= 1.2f; i -= 0.05f)
        {
            donutRect.localScale = new Vector3(i, i, i);
            donutsCounter.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForEndOfFrame();
        }
        donutsCounter.rectTransform.localScale = new Vector3(1, 1, 1);
        donutRect.localScale = new Vector3(1, 1, 1);
    }

    public void ClickScore()
    {
        
        StartCoroutine(Pulse());
    }
}
