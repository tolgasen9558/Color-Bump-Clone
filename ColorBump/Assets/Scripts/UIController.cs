using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public static UIController instance = null;

    [SerializeField]
    private GameObject _gameOverScreen;
    [SerializeField]
    private Text _infoText;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

	public void ShowGameOverScreen(bool hasFailed)
    {
        _infoText.text = hasFailed ? "You have failed!" : "Congratulations!";
        _gameOverScreen.SetActive(true);
    }

    public void DisableGameOverScreen()
    {
        _gameOverScreen.SetActive(false);
    }
}
