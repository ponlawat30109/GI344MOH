using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpRingSpawner : MonoBehaviour
{
    public int numbers;

    public float xPlus;
    public float xMinus;

    public float yPlus;
    public float yMinus;

    public GameObject warpBall;

    bool done = false;

    public void Spawn(int player)
    {

        if (done == true)
        {
            
            gameObject.SetActive(false);

            return;
        }
        for (int i = 0; i < numbers; i++)
        {
            float x = Random.Range(xPlus, xMinus);
            float y = Random.Range(yPlus, yMinus);

            GameObject ring = Instantiate(warpBall, new Vector3(x, y, 0f), warpBall.transform.rotation, transform);
            ring.GetComponent<Ring>().player = player;
        }
        
        done = true;
    }
}
