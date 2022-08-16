using UnityEngine;

public class Statistics : SingletonMonoBehavior<Statistics>
{
    #region Variables

    [SerializeField] private int _maxHp;

    #endregion


    #region Properties

    public int CurrentHp { get; set; }

    #endregion


    #region Unity lifecycle

    protected override void Awake()
    {
        base.Awake();
        CurrentHp = _maxHp;
    }

    #endregion
}