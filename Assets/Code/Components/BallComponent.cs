using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallComponent : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private float _throwForce;

    private GameObject _ball;
    private Rigidbody _ballRigidbody;

    private void Awake()
    {
        float ballPositionY = transform.position.y + _ballPrefab.transform.localScale.y / 2;
        Vector3 spawnPoint = new Vector3(transform.position.x, ballPositionY, transform.position.z);

        _ball = Instantiate(_ballPrefab, spawnPoint, Quaternion.identity);
        _ball.transform.SetParent(transform);
        _ball.GetComponent<BallController>().Platform = transform.gameObject;

        if (_ball.TryGetComponent<Rigidbody>(out Rigidbody ballRB))
        {
            _ballRigidbody = ballRB;
            return;
        }
        
        _ballRigidbody = _ballPrefab.AddComponent<Rigidbody>();
    }
    public void Throw()
    {
        _ball.transform.SetParent(null);
        _ballRigidbody.AddForce(new Vector3(0, _throwForce, 0), ForceMode.Impulse);
    }

    public void StopMoving()
    {
        _ballRigidbody.velocity = Vector3.zero;
    }
}
