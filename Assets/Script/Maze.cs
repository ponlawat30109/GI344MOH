using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    Mesh dataMesh;
    Mesh meshFilterChild;
    MeshRenderer meshRendererChild;

    [HideInInspector]public Color playerColor;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MazeChange", 0f, GameSystem.data.changeMazeSec);

        meshRendererChild = transform.GetChild(0).GetComponent<MeshRenderer>();
        meshFilterChild = transform.GetChild(0).GetComponent<MeshFilter>().mesh;
        meshFilterChild = dataMesh;
    }

    public void MazeChange()
    {
        dataMesh = GameSystem.data.maze[Random.Range(0, GameSystem.data.maze.Length)];
        GetComponent<MeshFilter>().mesh = dataMesh;
        GetComponent<MeshCollider>().sharedMesh = dataMesh;



        InvokeRepeating("MazeEffect", 0f, GameSystem.data.effectFrequency);
    }

    void MazeEffect()
    {

        Color endColor = playerColor;
        endColor.a = 0;
        meshRendererChild.material.color = Color.Lerp(playerColor, endColor, GameSystem.data.effectFrequency);
        playerColor = meshRendererChild.material.color;

        if (playerColor.a <= 0.1)
        {
            meshFilterChild = dataMesh;
            CancelInvoke();
            meshRendererChild.material.color = endColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
