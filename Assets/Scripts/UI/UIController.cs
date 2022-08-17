using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Variables

    [SerializeField] public GameObject _gameOverScreen;
    [SerializeField] private GameObject _pauseScreen;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _gameOverScreen.SetActive(false);
        _pauseScreen.SetActive(false);
    }

    private void Start()
    {
        PauseManager.Instance.OnPaused += Paused;
        HUD.Instance.OnGameOver += GameOver;
    }

    private void OnDestroy()
    {
        PauseManager.Instance.OnPaused -= Paused;
        HUD.Instance.OnGameOver -= GameOver;
    }

    #endregion


    #region Private methods

    private void Paused(bool isPaused)
    {
        _pauseScreen.SetActive(isPaused);
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        _gameOverScreen.SetActive(true);
    }

    #endregion
}