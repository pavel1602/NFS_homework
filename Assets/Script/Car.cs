using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class Car : MonoBehaviour
{
    [SerializeField] private GameObject _car;
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;


    private void Update()
    {
        var position = transform.position;
        var step = _speed * Time.deltaTime;
        var rotationStep = _speedRotation * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            _car.transform.position += _car.transform.forward * step;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _car.transform.position -= _car.transform.forward * step;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _car.transform.Rotate(0,rotationStep * -1,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _car.transform.Rotate(0,rotationStep * 1,0);
        }
    }
}
