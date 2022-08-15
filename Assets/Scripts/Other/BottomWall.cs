using System;
using UnityEngine;

public class BottomWall : MonoBehaviour
{
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }

    #endregion
}