using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class Stars : MonoBehaviour
{
    public GameObject star;
    public GameObject goldStar;

    void Start()
    {
        var rectTrans = gameObject.transform as RectTransform;
        float width=rectTrans.rect.width;

        int countStar = 3;// Random.Range(1, 5);
        int countGoldStar = Random.Range(0, countStar);
   
        float newX = (width / countStar)/2;
        


        for (float i = 0; i <= countGoldStar-1; i +=1)
        {

            float newPosX = -width / 2 + newX+ width*i/countStar;
            GameObject newItem = Instantiate(goldStar, transform.position, transform.rotation);
            newItem.name = gameObject.name + i.ToString();
            newItem.transform.SetParent(gameObject.transform);
            newItem.transform.localPosition = new Vector3(newPosX, 0, 0);

            
        }
        for (float i = countGoldStar; i <= countStar - 1; i += 1)
        {

            float newPosX = -width / 2 + newX + width * i / countStar;
            GameObject newItem = Instantiate(star, transform.position, transform.rotation);
            newItem.name = gameObject.name + i.ToString();
            newItem.transform.SetParent(gameObject.transform);
            //newItem.transform.parent = gameObject.transform;
            newItem.transform.localPosition = new Vector3(newPosX, 0, 0);

        }
    }
}
