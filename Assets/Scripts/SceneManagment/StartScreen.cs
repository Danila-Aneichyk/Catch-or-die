using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    #region Variables

    [SerializeField] public Button StartButton;

    [SerializeField] public SceneLoader SceneLoader;

    #endregion


    #region

    public void Start()
    {
        StartButton.onClick.AddListener(MoveToNextScene);
    }

    #endregion


    #region Private methods

    private void MoveToNextScene()
    {
        SceneLoader.SceneLoading();
    }

    #endregion
}