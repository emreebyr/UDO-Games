using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcMovement : MonoBehaviour
{

    [SerializeField] private float _horizontalLimit;
    [SerializeField] private float _horizontalSpeed;
    private float _horizontal;
    [SerializeField] public float _moveSpeed;


     void Update()
    {
        BallMoveForward();
        BallHorizontalMovement();
    }


    private void BallHorizontalMovement() {
        float _newX = 0;

        if(Input.GetMouseButton(0)) {
            _horizontal = Input.GetAxisRaw("Mouse X");
        }
        else
        {
            _horizontal = 0;
        }

        _newX = transform.position.x + _horizontal * _horizontalSpeed*20 * Time.deltaTime;
        _newX = Mathf.Clamp(_newX, -_horizontalLimit, _horizontalLimit);

        transform.position = new Vector3(
            _newX,
            transform.position.y,
            transform.position.z
        );

        
    }

    private void BallMoveForward() {

        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
