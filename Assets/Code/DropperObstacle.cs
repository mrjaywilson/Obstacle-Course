using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DropperObstacle : MonoBehaviour
{

    private float _dropTime = 0;
    private bool _hasDropped = false;
    private MeshRenderer _meshRenderer;

    [field: SerializeField]
    public float MinimumDropTime { get; set; }
    [field: SerializeField]
    public float MaximumDropTime { get; set; }


    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        GetComponent<Rigidbody>().useGravity = false;

        _dropTime = Random.Range(MinimumDropTime, MaximumDropTime);
    }

    private void Update()
    {
        if (!_hasDropped)
        {
            if (_dropTime < Time.time)
            {
                _meshRenderer.enabled = true;
                GetComponent<Rigidbody>().useGravity = true;
                _hasDropped = true;
            }
        }
    }
}
