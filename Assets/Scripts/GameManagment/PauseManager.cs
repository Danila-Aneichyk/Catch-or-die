using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseManager : SingletonMonoBehavior<PauseManager>
{
    #region Events

    public event Action<bool> OnPaused;

    #endregion
    
    #region Properties

    public bool IsPaused { get; private set; }

    #endregion


    #region Unity lifecycle

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    #endregion


    #region Public methods

    public void Resume()
    {
        IsPaused = false;
        Time.timeScale = 1;
        OnPaused?.Invoke(IsPaused);
    }
    
    public void ApplicationQuit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    #endregion


    #region Private methods 

    private void TogglePause()
    {
        CancelInvoke(nameof(PickUpsSpawn.SpawnPickUps));
        IsPaused = !IsPaused;
        Time.timeScale = IsPaused ? 0 : 1;
        OnPaused?.Invoke(IsPaused);
    }

    #endregion
}