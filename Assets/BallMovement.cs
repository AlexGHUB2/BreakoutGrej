using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    Rigidbody BM;

    // Start is called before the first frame update
    void Start()
    {
        BM = GetComponent<Rigidbody>();
        transform.position = new Vector3(2, 2.5f, 2);
        BM.AddForce(new Vector3(0, -1f, 0));

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 4;
        BM.velocity = BM.velocity.normalized * speed;
    }
}
