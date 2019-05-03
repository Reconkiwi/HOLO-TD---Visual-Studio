using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class continuemanager2 : MonoBehaviour, IInputClickHandler
{
    public bool section3Begin = false;
    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (GameObject.Find("Text").GetComponent<CanvasFadeIn>().section2Finished)
        {
            section3Begin = true;
            Debug.Log("section3begin");
        }

        else
        {
            section3Begin = false;
        }
    }
}
