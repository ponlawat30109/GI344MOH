using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class exit : MonoBehaviour
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Application.Quit();
    }
}
