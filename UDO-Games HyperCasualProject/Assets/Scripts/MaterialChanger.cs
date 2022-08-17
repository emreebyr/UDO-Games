using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;

public class MaterialChanger : MonoBehaviour
{
    public GameObject policecar;
    public GameObject ambulance;
    public GameObject firetruck;
    public GameObject poorguy;
    
     public TextMeshProUGUI scoreText;
     private int score;

    public int i=0;
    public int j=0;
    public int k=0;



    public List<GameObject> Police = new List<GameObject>();
    public List<GameObject> Firetruck = new List<GameObject>();
    public List<GameObject> Ambulance = new List<GameObject>();

    //public PlayerController Control;
    //public PcMovement Control2;


    void Start()
    {
        //Control = GetComponent<PlayerController>();
        //Control2 = GetComponent<PcMovement>();
    }

    void FixedUpdate()
    {
       scoreText.text = score.ToString();
    }

    
   void OnTriggerEnter(Collider other) 
        {
            
             //transform.DORewind ();
             //transform.DOScale (new Vector3 (0.1f, 0.1f, 0.1f), 0.25f);
             //transform.DORotate(new Vector3(180, 0, 0), 1, RotateMode.FastBeyond360);
             
         Vector3 OriginalScale= transform.localScale; DOTween.Sequence() .Append(transform.DOScale(new Vector3(OriginalScale.x + 0.05f, OriginalScale.y + 0.05f, OriginalScale.z + 0.05f), 0.3f).SetEase(Ease.Linear)) .Append(transform.DOScale(OriginalScale, 0.4f).SetEase(Ease.Linear));


             

        if(other.gameObject.tag=="policegameobject")
            {
               
               Destroy (other.gameObject);
               Debug.Log("kapsül toplandi");
               score=score+5;

            }

         if(other.gameObject.tag=="firegameobject")
            {
               
               Destroy (other.gameObject);
               Debug.Log("küp toplandi");
               score=score+10;

            }

         if(other.gameObject.tag=="ambulancegameobject")
            {
               
               Destroy (other.gameObject);
               Debug.Log("sphere toplandi");
               score=score+15;

            }

        if(other.gameObject.tag=="policecar")

            {
            if (policecar.activeInHierarchy == false )
            {
              policecar.SetActive(true);
            }   
            
            ambulance.SetActive(false);
            firetruck.SetActive(false);
            poorguy.SetActive(false);
            Police[i].SetActive(true);
            i++;
            Debug.Log("küp seçildi");

            }
     
        if(other.gameObject.tag=="firetruck")

            {  
            if (firetruck.activeInHierarchy == false )
            {
              firetruck.SetActive(true);
            }

            policecar.SetActive(false);
            ambulance.SetActive(false); 
            poorguy.SetActive(false);
            Firetruck[j].SetActive(true);
            j++;
            }

        if(other.gameObject.tag=="ambulance")

            {
            if (ambulance.activeInHierarchy == false )
            {
              ambulance.SetActive(true);
            }     

            policecar.SetActive(false);
            poorguy.SetActive(false);
            firetruck.SetActive(false);
            Ambulance[k].SetActive(true);
            k++;
         
            }
   }
}
