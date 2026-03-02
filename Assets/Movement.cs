using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(0.008f, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-0.008f, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0.04f, 0);
            Physics.CheckSphere(transform.position, 1f);
            
           
        }
        
    }

}
