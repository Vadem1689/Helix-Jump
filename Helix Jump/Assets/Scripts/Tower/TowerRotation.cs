using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class TowerRotation : MonoBehaviour
{
    [SerializeField] private float _rotatonSpeed;

    private Rigidbody _rigidbooy;


    private void Start()
    {
        _rigidbooy = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase==TouchPhase.Moved)
            {
                float torque = touch.deltaPosition.x * Time.deltaTime * _rotatonSpeed;
                _rigidbooy.AddTorque(Vector3.up * torque);

            }
        }
    }
}
