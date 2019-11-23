using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = 0;
        float vertical = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vertical = 1 * GameSystem.data.playerSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vertical = -1 * GameSystem.data.playerSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = 1 * GameSystem.data.playerSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = -1 * GameSystem.data.playerSpeed;
        }
        rigid.velocity = new Vector3(horizontal, vertical, 0);
    }
}
