using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour, IPointerDownHandler
{
    public string sceneName = "Game";
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene(sceneName);
    }
}
