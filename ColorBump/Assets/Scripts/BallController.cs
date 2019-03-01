using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour {

    [SerializeField]
    private float _speed;

    private Vector3 _mouseDragStart;
    private bool _isDragging;
    private Vector3 _moveVector;
    private Rigidbody _rigidbody;
    private Vector3 _lastMousePosition;

    void Start ()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _lastMousePosition = Input.mousePosition;
	}
	
	void Update ()
    {
        _moveVector = GetMouseMovementVector();
        
        _rigidbody.MovePosition(transform.position + _moveVector / 35);
	}

    private Vector3 GetMouseMovementVector()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 result = Input.mousePosition - _lastMousePosition;
            _lastMousePosition = Input.mousePosition;
            result.z = result.y;
            result.y = 0;
            return result;
        }

        _lastMousePosition = Input.mousePosition;
        return Vector3.zero;
    }
}
