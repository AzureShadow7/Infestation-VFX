using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : MonoBehaviour
{
    public ParticleSystem Infestation;
    Vector3 spawnPoint = new Vector3(0.0f, 0.0f, 0.0f);


    // Start is called before the first frame update
    void Start()
    {
        //var spellEmission = Infestation.emission;
        //spellEmission.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //var spellEmission = Infestation.emission;

        if (Input.GetKeyDown(KeyCode.I))
        {
            //spellEmission.enabled = true;
            Instantiate(Infestation, spawnPoint, Quaternion.identity);
            Infestation.Play();

            Debug.Log("it's playing");
        }
    }
}
