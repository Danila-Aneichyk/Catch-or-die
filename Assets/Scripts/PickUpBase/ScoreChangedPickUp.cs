using UnityEngine;

public class ScoreChangedPickUp : PickUpBase
{
    #region Variables

    [SerializeField] private int _score;

    #endregion


    protected override void ApplyEffect(Collision2D col)
    {
        ScoreManager.Instance.ChangeScore(_score);
    }
}