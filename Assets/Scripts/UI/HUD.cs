using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : SingletonMonoBehavior<HUD>
{
    #region Variables

    [SerializeField] public SceneLoader SceneLoader;
    [Header("Values")]
    [SerializeField] public int NumOfHearts;
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI _scoreLabel;
    [SerializeField] public Image[] hearts;
    [SerializeField] public Sprite FullHeart;
    [SerializeField] public Sprite EmptyHeart;

    #endregion


    #region Events

    public event Action OnGameOver;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        ScoreManager.Instance.OnScoreChange += ScoreChanged;

        ScoreChanged(ScoreManager.Instance.Score);
    }

    private void Update()
    {
        int healthPoints = Statistics.Instance.CurrentHp;
        if (healthPoints > NumOfHearts)
        {
            healthPoints = NumOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = i < Mathf.RoundToInt(healthPoints) ? FullHeart : EmptyHeart;

            hearts[i].enabled = i < NumOfHearts;

            if (healthPoints <= 0)
            {
                OnGameOver?.Invoke(); 
            }
            
        }
    }

    private void OnDestroy()
    {
        ScoreManager.Instance.OnScoreChange -= ScoreChanged;
    }

    #endregion


    #region Private methods

    private void ScoreChanged(int score)
    {
        _scoreLabel.text = $"Score: {ScoreManager.Instance.Score}";
    }

    #endregion
}