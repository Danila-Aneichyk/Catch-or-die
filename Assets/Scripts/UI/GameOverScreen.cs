using System;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _restartButton;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _quitButton.onClick.AddListener(Quit);
        _restartButton.onClick.AddListener(Restart);
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
    }

    #endregion
}