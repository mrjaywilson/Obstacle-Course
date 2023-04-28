using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public bool wasHit { get; set; } = false;

    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player") && !wasHit)
        {
            if (_meshRenderer.material.color != Color.red)
            {
                _meshRenderer.material.color = Color.red;
                wasHit = true;
            }
        }
    }
}
