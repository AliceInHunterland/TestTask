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
        float width = gameObject.transform.position.x;
        Debug.Log(width);
        int countStar = Random.Range(1, 5);
        int countGoldStar = Random.Range(0, countStar);
        Debug.Log(countStar);
        float newX = (width / countStar)/2;
        width = 200;
        Debug.Log(gameObject.transform.position);

        for (float i = 0; i <= countGoldStar-1; i +=1)
        {

            float newPosX = -width / 2 + newX+ width*i/countStar;
            GameObject newItem = Instantiate(goldStar, transform.position, transform.rotation);
            newItem.name = gameObject.name + i.ToString();

            newItem.transform.parent = gameObject.transform;
            newItem.transform.localPosition = new Vector3(newPosX, 0, 0);

            //newX = 2 * newX;

            Debug.Log(newItem.transform.position);
            Debug.Log(newItem.transform.localPosition); }
        for (float i = countGoldStar; i <= countStar - 1; i += 1)
        {

            float newPosX = -width / 2 + newX + width * i / countStar;
            GameObject newItem = Instantiate(star, transform.position, transform.rotation);
            newItem.name = gameObject.name + i.ToString();

            newItem.transform.parent = gameObject.transform;
            newItem.transform.localPosition = new Vector3(newPosX, 0, 0);

            //newX = 2 * newX;

            Debug.Log(newItem.transform.position);
            Debug.Log(newItem.transform.localPosition);
        }
    }
}
