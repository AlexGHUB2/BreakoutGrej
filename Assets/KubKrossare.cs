using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KubKrossare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnCollisionEnter(Collision collision)
    {
        GameObject otherGameObject = collision.gameObject;
        BliKrossade hitblock = otherGameObject.GetComponent<BliKrossade>();
        
        if (hitblock != null)
        {

            hitblock.Dö();
        }



    }
}
