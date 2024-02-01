using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class SpellController : MonoBehaviour
{
    public ParticleSystem Infestation;
    public GameObject indicator;
    private Camera cam = null;

    Vector3 spawnPoint = new Vector3(0.0f, 0.0f, 0.0f);


    // Start is called before the first frame update
    void Start()
    {
        var spellEmission = Infestation.emission;
        spellEmission.enabled = false;

        cam = Camera.main;
    }

    void SpellPosition()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            //create a ray from camera to mouse position
            Ray spawnray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;

            if(Physics.Raycast(spawnray, out hit))
            {
                Instantiate(indicator, hit.point, Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        var spellEmission = Infestation.emission;

        if (Input.GetKeyDown(KeyCode.I))
        {
            spellEmission.enabled = true;
            Instantiate(Infestation, spawnPoint, Quaternion.identity);
            Infestation.Play();

            Debug.Log("it's playing");

            //SpellPosition();
        }

        SpellPosition();
    }
}
