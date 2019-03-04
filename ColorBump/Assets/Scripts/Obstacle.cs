using UnityEngine;

public class Obstacle : MonoBehaviour {

    [SerializeField]
    private bool _isFatal;
    private Rigidbody _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.collider.gameObject.CompareTag("Ground"))
        {
            _rigidBody.constraints = RigidbodyConstraints.None;
        }

        if (_isFatal && collision.collider.gameObject.CompareTag("Ball"))
        {
            GameManager.instance.FinishGame(true);
        }
    }
}
