using UnityEngine;

public class SpeedFallChangedPickUp : PickUpBase
{
    #region Variables

    [SerializeField] public int speed; 

    #endregion
    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<PickUpsFalls>().ChangeSpeed(speed);
    }
}