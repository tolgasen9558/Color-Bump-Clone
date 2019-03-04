using UnityEngine;

public class WorldMover : MonoBehaviour {

    [SerializeField]
    private float _scrollSpeed = 3.0f;

    private bool _isMoving = false;

    private void Update()
    {
        if(_isMoving)
        {
            transform.Translate(Vector3.back * _scrollSpeed * Time.deltaTime);
        }
    }

    public void StartMoving()
    {
        _isMoving = true;
    }

    public void StopMoving()
    {
        _isMoving = false;
    }
}
