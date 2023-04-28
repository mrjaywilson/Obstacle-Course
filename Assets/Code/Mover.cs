using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();

        Application.targetFrameRate = 60;
        DisplayInstructions();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    private void DisplayInstructions()
    {
        Debug.Log("Use WASD to move.");
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;


        _rigidbody.MovePosition(transform.position + new Vector3(xValue, 0, zValue));

        //transform.Translate(xValue, 0, zValue);


    }
}
