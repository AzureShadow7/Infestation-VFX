using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem[] infestation;

    // Start is called before the first frame update
    void Start()
    {
        infestation = GetComponentsInChildren<ParticleSystem>();

        foreach(ParticleSystem p in infestation)
        {
            p.Stop();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            foreach (ParticleSystem p in infestation)
            {
                p.Play();
            }
            
        }
    }
}
