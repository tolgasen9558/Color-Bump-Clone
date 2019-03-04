using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour {

    [SerializeField]
    private float _sensitivity = 1.25f;
    private Vector3 _mouseDragStart;
    private Vector3 _mouseMovementVector;
    private float _maxSpeed = 15.0f;
    private Rigidbody _rigidbody;
    private Vector3 _lastMousePosition;
    private bool _hasStarted;

    void Start ()
    {
        _hasStarted = false;
        _rigidbody = GetComponent<Rigidbody>();
        _lastMousePosition = Input.mousePosition;
	}
	
	void Update ()
    {
        _mouseMovementVector = GetMouseMovementVector();

        if (_mouseMovementVector != Vector3.zero)
        {
            if(_mouseMovementVector.sqrMagnitude > _maxSpeed * _maxSpeed)
            {
                _mouseMovementVector = _mouseMovementVector.normalized * _maxSpeed;
            }
            _rigidbody.velocity = _mouseMovementVector;
        }

	}


    private Vector3 GetMouseMovementVector()
    {
        if(Input.GetMouseButton(0))
        {
            if(!_hasStarted)
            {
                GameManager.instance.StartGame();
                _hasStarted = true;
            }
            Vector3 result = (Input.mousePosition - _lastMousePosition) * _sensitivity;
            _lastMousePosition = Input.mousePosition;
            result.z = result.y;
            result.y = 0;
            return result;
        }

        _lastMousePosition = Input.mousePosition;
        return Vector3.zero;
    }
}
