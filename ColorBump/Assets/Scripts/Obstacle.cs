using UnityEngine;

public class Obstacle : MonoBehaviour {

    [SerializeField]
    private bool _isFatal;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(_isFatal && collision.collider.gameObject.CompareTag("Ball"))
            Debug.Log("GameOver!!");
    }
}
