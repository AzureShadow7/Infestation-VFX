//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ParticleTest : MonoBehaviour
//{
//    public ParticleSystem testParticles;

//    // Start is called before the first frame update
//    void Start()
//    {
//        testParticles.Stop();
//        testParticles.Clear();
//        testParticles.enableEmission = false;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(Input.GetKeyDown(KeyCode.V))
//        {
//            testParticles.Play();
//            testParticles.enableEmission = true;
//        }

//        if(testParticles.isStopped)
//        {
//            Debug.Log("The particles have stopped playing");
//        }
//    }
//}
