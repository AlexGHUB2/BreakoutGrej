using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody>();
        transform.position = new Vector3(2, 2, 2);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Player.AddForce(new Vector3(-5, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            Player.AddForce(new Vector3(5, 0, 0));
        }
    }

}
