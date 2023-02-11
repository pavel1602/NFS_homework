using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField] private Car _car;
    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        _car = FindObjectOfType<Car>();
    }

    private void LateUpdate()
    {
        gameObject.transform.position = _car.transform.position + _offset;
    }
}
