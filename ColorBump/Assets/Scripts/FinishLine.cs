using UnityEngine;

public class FinishLine : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
            GameManager.instance.FinishGame(false);
    }
}
