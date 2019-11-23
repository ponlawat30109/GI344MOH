using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    #region Static Stuff
    public static GameSystem data;

    public GameObject bluePlayer;
    public GameObject redPlayer;
    public float playerSpeed;

    public int gameTimeSec = 1;//must > 0
    public int changeMazeSec;//must > 0

    public GameObject mazeObject;
    public Material mazeMaterial;
    public Mesh[] maze;

    public float effectFrequency;
    //public float effectStep;
    public MeshRenderer KeyPostEffect;

    public Text gameOver;
    public Text blueWin;
    public Text redWin;
    public Text time;

    public GameObject goal;
    public Material goalMaterial;
    [HideInInspector] public int goalSet;

    public Material redMaterial;
    public Material blueMaterial;

    public GameObject keyObject;
    public warpRingSpawner warpRingSpawner;

    void Awake()
    {
        data = this;
    }
    #endregion

    public static void CancelInvokes()
    {
        GameSystem.data.time.gameObject.GetComponent<Time>().CancelInvoke();
        GameSystem.data.mazeObject.GetComponent<Maze>().CancelInvoke();
        GameSystem.data.keyObject.GetComponent<Key>().CancelInvoke();

        audioSystem.data.PlaySound(1);
    }
}
