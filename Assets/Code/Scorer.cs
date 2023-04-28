using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _score = 0;

    private void OnCollisionEnter(Collision other)
    {
        
        if (!other.gameObject.GetComponent<ObjectHit>().wasHit)
        {
            _score++;
            Debug.Log($"You've bumped into something: {_score} times!");
        }
        else
        {
            Debug.Log("Already hit this object!");
        }

    }
}
