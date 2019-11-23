using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [HideInInspector]
    public int player = 0;

    void Start()
    {
        if(player == 1)
        {
            GetComponent<MeshRenderer>().material.color = GameSystem.data.blueMaterial.color;
        }
        if (player == 2)
        {
            GetComponent<MeshRenderer>().material.color = GameSystem.data.redMaterial.color;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(player == 1 && other.gameObject.tag == "Blue")
        {
            other.transform.position = GameSystem.data.keyObject.transform.position;
        }
        else if(other.gameObject.tag != "Untagged") { audioSystem.data.PlaySound(2); }
        if (player == 2 && other.gameObject.tag == "Red")
        {
            other.transform.position = GameSystem.data.keyObject.transform.position;
        }
        else if (other.gameObject.tag != "Untagged") { audioSystem.data.PlaySound(2); }
        Destroy(this.gameObject);
    }
}
