using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    private WorldMover _worldMover;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        _worldMover = GameObject.FindObjectOfType<WorldMover>();
        _worldMover.StopMoving();
    }

    public void StartGame()
    {
        UIController.instance.DisableGameOverScreen();
        _worldMover = GameObject.FindObjectOfType<WorldMover>();
        _worldMover.StartMoving();
    }

    public void FinishGame(bool hasFailed)
    {
        _worldMover.StopMoving();
        UIController.instance.ShowGameOverScreen(hasFailed);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        _worldMover.StopMoving();
        UIController.instance.DisableGameOverScreen();
    }
}
