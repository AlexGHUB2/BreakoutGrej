using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BliKrossade : MonoBehaviour
{
    int Hp = 1; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dö()
    {
        Hp -= 1;

        if (Hp == 0)
        {
            Destroy(gameObject);
        }

        
        

    }   


}
