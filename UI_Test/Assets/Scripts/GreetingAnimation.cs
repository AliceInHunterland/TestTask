using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreetingAnimation : MonoBehaviour
{
    public RectTransform gunScale;


   private void Start()
    {
        gunScale = GetComponent<RectTransform>();
        StartCoroutine(GunScaling());
    }
    
    private IEnumerator GunScaling()
    {
        for (float i = 1f; i <= 1.2f; i += 0.05f)
        {
            gunScale.localScale = new Vector3(i, i, i);

            yield return new WaitForSeconds(0.1f);
        }
        gunScale.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        for (float i = 1f; i >= 1.2f; i -= 0.05f)
        {
            gunScale.localScale = new Vector3(i, i, i);
            yield return new WaitForSeconds(0.1f);
        }

        gunScale.localScale = new Vector3(1, 1, 1);
    }
   
}
