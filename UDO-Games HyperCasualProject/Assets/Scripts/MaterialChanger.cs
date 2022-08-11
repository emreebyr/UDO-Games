using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;

    public GameObject capsule;
    public PlayerController Control;

    void Start()
    {
        //Control = GetComponent<PlayerController>();
        
    }

    
   void OnTriggerEnter(Collider other) 
        {

             transform.DORewind ();
             transform.DOPunchScale (new Vector3 (5f, 5f, 5f), 0.25f);
             transform.DORotate(new Vector3(180, 0, 0), 1, RotateMode.FastBeyond360);

        if(other.gameObject.tag=="cube")

        {
        sphere.SetActive(false);
        cube.SetActive(true);
        capsule.SetActive(false);
        Debug.Log("Cube");
    
        }
     
        if(other.gameObject.tag=="capsule")

        {  
        cube.SetActive(false);
        sphere.SetActive(false);
        capsule.SetActive(true);
        Debug.Log("Capsule");

        }

        if(other.gameObject.tag=="sphere")

        {  
        cube.SetActive(false);
        sphere.SetActive(true);
        capsule.SetActive(false);
        Debug.Log("Sphere");

        }
   }
}
