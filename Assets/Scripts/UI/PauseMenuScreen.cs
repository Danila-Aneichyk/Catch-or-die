using System;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuScreen : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _quitButton;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _continueButton.onClick.AddListener(Resume);
        _restartButton.onClick.AddListener(Restart);
        _quitButton.onClick.AddListener(Quit);
    }

    #endregion


    #region Private methods

    private void Quit()
    {
        PauseManager.Instance.ApplicationQuit();
    }

    private void Restart()
    {
        PauseManager.Instance.Restart();    
        FindObjectOfType<UIController>()._gameOverScreen.SetActive(false);
    }

    private void Resume()
    {
        PauseManager.Instance.Resume(); 
    }

    #endregion
}