using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = 15f;
    private float _leftBound = -15;
    private PlayerController _playerController;

    void Start()
    {
        _playerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (!_playerController.GameOver)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * _speed));
        }

        if (transform.position.x < _leftBound && gameObject.CompareTag("Object"))
        {
            Destroy(gameObject);
        }
    }
}
