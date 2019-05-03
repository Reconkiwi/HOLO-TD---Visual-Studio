using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class continueManager : MonoBehaviour, IInputClickHandler
{
    public bool section2Begin = false;
    public void OnInputClicked(InputClickedEventData eventData)
        {
        if (GameObject.Find("Text").GetComponent<CanvasFadeIn>().section1Finished)
        {
            section2Begin = true;
            Debug.Log("section2begin");
        }

        else
        {
            section2Begin = false;
        }

    }
}
