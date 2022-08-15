using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;

    public GameObject capsule;
    public GameObject capsulegameobject;
    public GameObject cubegameobject;
    public GameObject spheregameobject;

    public int i=0;
    public int j=0;
    public int k=0;



    public List<GameObject> Küpler = new List<GameObject>();
    public List<GameObject> Kapsüller = new List<GameObject>();
    public List<GameObject> Daireler = new List<GameObject>();

    //public PlayerController Control;
    //public PcMovement Control2;


    void Start()
    {
        //Control = GetComponent<PlayerController>();
        //Control2 = GetComponent<PcMovement>();
    }

    void update()
    {

    }

    
   void OnTriggerEnter(Collider other) 
        {

             //transform.DORewind ();
             //transform.DOPunchScale (new Vector3 (1f, 1f, 1f), 0.25f);
             //transform.DORotate(new Vector3(180, 0, 0), 1, RotateMode.FastBeyond360);

             

        if(other.gameObject.tag=="capsulegameobject")
         {
            
          
            Destroy (other.gameObject);
            Debug.Log("kapsül toplandi");

         }

         if(other.gameObject.tag=="cubegameobject")
         {
            
            Destroy (other.gameObject);
            Debug.Log("küp toplandi");

         }

         if(other.gameObject.tag=="spheregameobject")
         {
            
            Destroy (other.gameObject);
            Debug.Log("sphere toplandi");

         }

        if(other.gameObject.tag=="cube")

        {
        sphere.SetActive(false);
        cube.SetActive(true);
        capsule.SetActive(false);
        Küpler[i].SetActive(true);
        i++;
        Debug.Log("küp seçildi");

        

          
       
   
    
        }
     
        if(other.gameObject.tag=="capsule")

        {  
        cube.SetActive(false);
        sphere.SetActive(false);
        capsule.SetActive(true);

        Kapsüller[j].SetActive(true);
        j++;
    
  


        
         

        }

        if(other.gameObject.tag=="sphere")

        {  
        cube.SetActive(false);
        sphere.SetActive(true);
        capsule.SetActive(false);
        Daireler[k].SetActive(true);
        k++;
    
      

      


        }
   }
}
