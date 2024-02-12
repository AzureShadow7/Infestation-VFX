//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.InputSystem;
//using UnityEngine;

//public class SpellController : MonoBehaviour
//{
//    public ParticleSystem Infestation;
//    public GameObject indicator;
//    GameObject indicatorClone;
//    //ParticleSystem infestationClone;
//    private Camera cam = null;


//    public bool isSpellCast;

//    // Start is called before the first frame update
//    void Start()
//    {
//        //var spellEmission = Infestation.emission;
//        Infestation.enableEmission = false;

//        cam = Camera.main;


//        isSpellCast = false;
//    }

//    public bool CastingSpell(bool beginCast)
//    {
//        if (beginCast == true)
//        {
//            indicatorClone = Instantiate(indicator);
//            return true;
//        }
//        else
//        {
//            Destroy(indicatorClone);
//            return false;
//        }
//    }

//    void SpellPosition()
//    {
//        if(Input.GetKeyDown(KeyCode.P) && isSpellCast == false)
//        {
//            CastingSpell(true);
//            isSpellCast = true;

//            //var spellEmission = Infestation.emission;
//        }

//        if (Input.GetKeyDown(KeyCode.L) && isSpellCast == true)
//        {
//            //create a ray from camera to mouse position
//            Ray spawnray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
//            RaycastHit hit;

//            //if ray hits spawn the indicator
//            if (Physics.Raycast(spawnray, out hit))
//            {
//                //spawn object at the mouse position taking the y-axis/height of the object into account
//                Instantiate(Infestation, new Vector3(hit.point.x, 0.0f, hit.point.z), Quaternion.identity);
//                Infestation.Play();
//                Infestation.enableEmission = true;
//                Debug.Log("it's playing");
//                isSpellCast = true;


//                //if (infestationClone.isStopped)
//                //{
//                //    Debug.Log("Stopped");
//                //    infestationClone.Stop();
//                //    infestationClone.Clear();




//                //    //Forget this for now
//                //    isSpellCast = false;

//                //    CastingSpell(false);
//                //}
//            }
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        SpellPosition();

//        if (Infestation.isStopped)
//        {
//            Debug.Log("Stopped");
//            Infestation.Stop();
//            Infestation.Clear();
//            Infestation.enableEmission = false;

//            //Forget this for now
//            //isSpellCast = false;

//            //CastingSpell(false);
//        }
//    }
//}
