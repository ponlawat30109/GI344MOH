using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    string i = "";
    private void OnCollisionEnter(Collision collision)
    {
        if(i == "OK") { return; }

        string bumb = collision.gameObject.tag;
        if (bumb == "Blue" && bumb != i)
        {
            GameSystem.data.mazeObject.GetComponent<Maze>().MazeChange();
            GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[0].color = GameSystem.data.redMaterial.color;
            GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[1].color = GameSystem.data.redMaterial.color;

            GameSystem.data.mazeObject.GetComponent<Maze>().playerColor = GameSystem.data.blueMaterial.color;
            audioSystem.data.PlaySound(0);

            GameSystem.data.warpRingSpawner.Spawn(2);//ช่วยคู่แข่งสีแดง

            thisColor = GameSystem.data.goalMaterial.color;
            InvokeRepeating("PostEffect", 0f, GameSystem.data.effectFrequency);

            if (i == "")//คู่แข่งยังไม่เข้า
            {
                i = "Blue";

                GameSystem.data.goalSet = 1;
                GameSystem.data.goal.GetComponent<MeshRenderer>().material = GameSystem.data.blueMaterial;
            }
            else if (i != "Blue")//เข้าตามขู่แข่ง
            {
                GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[0].color = GameSystem.data.mazeMaterial.color;
                GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[1].color = GameSystem.data.mazeMaterial.color;

                GameSystem.data.goalSet = 3;
                GameSystem.data.goal.GetComponent<MeshRenderer>().material = GameSystem.data.goalMaterial;

                i = "OK";
            }

        }
        if (bumb == "Red" && bumb != i)
        {
            GameSystem.data.mazeObject.GetComponent<Maze>().MazeChange();
            GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[0].color = GameSystem.data.blueMaterial.color;
            GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[1].color = GameSystem.data.blueMaterial.color;

            GameSystem.data.mazeObject.GetComponent<Maze>().playerColor = GameSystem.data.redMaterial.color;
            audioSystem.data.PlaySound(0);

            GameSystem.data.warpRingSpawner.Spawn(1);//ช่วยคู่แข่งสีฟ้า

            thisColor = GameSystem.data.goalMaterial.color;
            InvokeRepeating("PostEffect", 0f, GameSystem.data.effectFrequency);

            if (i == "")//คู่แข่งยังไม่เข้า
            {
                i = "Red";
                GameSystem.data.goalSet = 2;

                GameSystem.data.goal.GetComponent<MeshRenderer>().material = GameSystem.data.redMaterial;
            }
            else if (i != "Red")//เข้าตามขู่แข่ง
            {
                GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[0].color = GameSystem.data.mazeMaterial.color;
                GameSystem.data.keyObject.GetComponent<MeshRenderer>().materials[1].color = GameSystem.data.mazeMaterial.color;

                GameSystem.data.goalSet = 3;
                GameSystem.data.goal.GetComponent<MeshRenderer>().material = GameSystem.data.goalMaterial;

                i = "OK";
            }
        }
        
    }
    Color thisColor;

    void PostEffect()
    {
        Color endColor = thisColor;
        endColor.a = 0;
        GameSystem.data.KeyPostEffect.material.color = Color.Lerp(thisColor, endColor, GameSystem.data.effectFrequency);
        thisColor = GameSystem.data.KeyPostEffect.material.color;

        if (thisColor.a <= 0.1)
        {
            CancelInvoke();
            GameSystem.data.KeyPostEffect.material.color = endColor;
        }
    }
}
