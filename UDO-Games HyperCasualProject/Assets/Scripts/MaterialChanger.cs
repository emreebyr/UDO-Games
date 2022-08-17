using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MaterialChanger : MonoBehaviour
{
    public GameObject policecar;
    public GameObject ambulance;
    public GameObject firetruck;
    public GameObject poorguy;

   public PlayerController Control;
    
     public TextMeshProUGUI scoreText;
     private int score;

    public int i=0;
    public int j=0;
    public int k=0;



    public List<GameObject> Police = new List<GameObject>();
    public List<GameObject> Firetruck = new List<GameObject>();
    public List<GameObject> Ambulance = new List<GameObject>();


    void Start()
    {
         Control = GetComponent<PlayerController>();

    }

    void FixedUpdate()
    {
       scoreText.text = score.ToString();
    }

    
   void OnTriggerEnter(Collider other) 
        {
                    
         Vector3 OriginalScale= transform.localScale; DOTween.Sequence() .Append(transform.DOScale(new Vector3(OriginalScale.x + 0.009f, OriginalScale.y + 0.009f, OriginalScale.z + 0.009f), 0.3f).SetEase(Ease.Linear)) .Append(transform.DOScale(OriginalScale, 0.6f).SetEase(Ease.Linear));
         Destroy (other.gameObject);


             

        if(other.gameObject.tag=="policegameobject")
            {
               

               score=score+5;

            }

         if(other.gameObject.tag=="firegameobject")
            {
               
               score=score+10;

            }

         if(other.gameObject.tag=="bed")
            {
               
               score=score-15;

            }

         if(other.gameObject.tag=="ambulancegameobject")
            {
               

               score=score+15;

            }

            if(other.gameObject.tag=="finishline")
            {
               

               Debug.Log("OYUNBİTTİ");

               Invoke("finishdelay",1f);

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

   void finishdelay()
               {
                  Control.GoForward = false;
                   Invoke("nextLevel", 3.0f);

               }

    void nextLevel()
    {
      SceneManager.LoadScene("level2");
    }           

}
