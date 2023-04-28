using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [field: SerializeField]
    public float SpinDirection { get; set; }

    [SerializeField] private float _speed;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, SpinDirection, 0) * _speed);
    }
}
