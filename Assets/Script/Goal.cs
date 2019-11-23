using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Blue" && GameSystem.data.goalSet == 1)
        {
            GameSystem.data.bluePlayer.SetActive(false);
            GameSystem.data.redPlayer.SetActive(false);
            GameSystem.data.time.gameObject.SetActive(false);
            GameSystem.data.blueWin.gameObject.SetActive(true);

            GameSystem.CancelInvokes();
        }
        if (collision.gameObject.tag == "Red" && GameSystem.data.goalSet == 2)
        {
            GameSystem.data.bluePlayer.SetActive(false);
            GameSystem.data.redPlayer.SetActive(false);
            GameSystem.data.time.gameObject.SetActive(false);
            GameSystem.data.redWin.gameObject.SetActive(true);

            GameSystem.CancelInvokes();
        }
        if (collision.gameObject.tag == "Blue" && GameSystem.data.goalSet == 3)
        {
            GameSystem.data.bluePlayer.SetActive(false);
            GameSystem.data.redPlayer.SetActive(false);
            GameSystem.data.time.gameObject.SetActive(false);
            GameSystem.data.blueWin.gameObject.SetActive(true);

            GameSystem.CancelInvokes();
        }
        if (collision.gameObject.tag == "Red" && GameSystem.data.goalSet == 3)
        {
            GameSystem.data.bluePlayer.SetActive(false);
            GameSystem.data.redPlayer.SetActive(false);
            GameSystem.data.time.gameObject.SetActive(false);
            GameSystem.data.redWin.gameObject.SetActive(true);

            GameSystem.CancelInvokes();
        }
    }

}
