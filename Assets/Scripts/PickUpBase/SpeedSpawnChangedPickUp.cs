using UnityEngine;

public class SpeedSpawnChangedPickUp : PickUpBase
{
    #region Variables

    [SerializeField] public float speed;

    #endregion


    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<PickUpsSpawn>().ChangeSpeed(speed);
    }
}