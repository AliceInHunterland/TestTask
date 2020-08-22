using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CrossButton : MonoBehaviour
{
   public void ClickCross()
    {
        EditorApplication.isPlaying = false;
    }
}
