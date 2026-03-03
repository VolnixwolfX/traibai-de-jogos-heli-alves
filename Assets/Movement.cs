using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    int PuloI = 0;
    int PuloF = 0;
    int frame=0;
    bool pulando = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frame = frame + 1;
        if (Input.GetKey("d"))
        {
            transform.Translate(0.015f, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-0.015f, 0, 0);
        }
        if (frame - PuloI > 300&&!pulando)
        {
            if (Input.GetKey("w"))
            {
                
                PuloI = frame;
                pulando = true;

            }

        }

        if (pulando)
        {
            transform.Translate(0, 0.06f, 0);
            Physics.CheckSphere(transform.position, 1f);
        }

        if(frame - PuloI > 60)
        {
            pulando = false;
        }
        
    }

}
