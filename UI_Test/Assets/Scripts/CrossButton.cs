using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class CrossButton : MonoBehaviour
{
   public void ClickCross()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
