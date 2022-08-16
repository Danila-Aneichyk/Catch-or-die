using UnityEngine;

public class BottomWall : MonoBehaviour
{
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(Tags.PositivePickUp))
        {
            DecrementHp(); 
        }
        Destroy(col.gameObject); 
        
    }

    #endregion


    #region Private methods

    private void DecrementHp()
    {
        Statistics.Instance.CurrentHp--;
    }

    #endregion
}