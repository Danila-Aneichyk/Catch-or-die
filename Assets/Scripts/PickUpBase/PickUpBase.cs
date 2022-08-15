using UnityEngine;

public abstract class PickUpBase : MonoBehaviour
{
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag(Tags.Pad))
            return;

        ApplyEffect(col);
        Destroy(gameObject);
    }

    #endregion


    #region Private regions

    protected abstract void ApplyEffect(Collision2D col);

    #endregion
}