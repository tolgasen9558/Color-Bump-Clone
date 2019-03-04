using UnityEngine;

public class WorldMover : MonoBehaviour {

    [SerializeField]
    private float _scrollSpeed = 3.0f;

    private void Update()
    {
        transform.Translate(Vector3.back * _scrollSpeed * Time.deltaTime);
    }
}
