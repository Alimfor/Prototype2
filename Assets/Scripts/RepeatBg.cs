using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBg : MonoBehaviour
{
    private Vector3 _startPos;
    
    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        if (transform.position.x < _startPos.x - 112.5)
        {
            transform.position = _startPos;
        }
    }
}
