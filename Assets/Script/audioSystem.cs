using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSystem : MonoBehaviour
{
    #region Static Stuff
    public static audioSystem data;

    AudioSource[] sound;
    #endregion

    void Awake()
    {
        int o = transform.childCount;
        sound = new AudioSource[o];

        for(int i = 0; i < o; i++)
        {
            sound[i] = transform.GetChild(i).GetComponent<AudioSource>();
        }

        data = this;
    }
    public void PlaySound(int index)
    {
        sound[index].Play();
    }
}
