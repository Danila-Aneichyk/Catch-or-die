using UnityEngine;

public class IncrementHpPickUp : PickUpBase
{
    protected override void ApplyEffect(Collision2D col)
    {
        Statistics.Instance.CurrentHp--; 
        
        if (Statistics.Instance.CurrentHp <= 0)
        {
            //TODO: GameOver 
        }
    }
}