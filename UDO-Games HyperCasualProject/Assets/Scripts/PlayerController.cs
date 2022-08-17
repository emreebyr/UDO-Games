using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public float ForwardSpeed;
    public Touch touch;
    public float speedModifier;
    public bool GoForward;
    
    public TextMeshProUGUI startingText;


   


    
    void Start()
    {
        GoForward= false;
    }

    void Update()
    {   
          
            if(GoForward)
            {
                transform.Translate(0,0,ForwardSpeed*Time.deltaTime);
                Destroy(startingText);

            }
        
        if (Input.touchCount>0)
        {   
            
            touch = Input.GetTouch(0);
            GoForward = true;
            
            if (touch.phase == TouchPhase.Moved)
            {
                
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x,-7,7f) + touch.deltaPosition.x * speedModifier/15,
                    transform.position.y,
                    transform.position.z
                );
            }
        }

        
    }
}