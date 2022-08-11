using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float ForwardSpeed;
    public Touch touch;
    public float speedModifier;

    public bool GoForward;
    private float _lastFrameFingerPositionX;
    private float _moveFactorX;
    public float MoveFactorX => _moveFactorX;
    
    void Start()
    {
        GoForward= false;
    }

    void Update()
    {   
          
            if(GoForward)
            {
                transform.Translate(0,0,ForwardSpeed*Time.deltaTime);

            }

             if (Input.GetMouseButtonDown(0))
            {   

                GoForward = true;
               
            }

        
           
        if (Input.touchCount>0)
        {   
            
            touch = Input.GetTouch(0);
            GoForward = true;
            if (touch.phase == TouchPhase.Moved)
            {
                
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x,-50f,50f) + touch.deltaPosition.x * speedModifier/15,
                    transform.position.y,
                    transform.position.z
                );
            }
        }

        
    }
}