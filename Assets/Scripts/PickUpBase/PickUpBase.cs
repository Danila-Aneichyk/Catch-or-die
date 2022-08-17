using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class PickUpBase : MonoBehaviour
{
    #region Variables

    private Rigidbody2D _rb;

    [SerializeField] private AudioClip _audioClip;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag(Tags.Pad))
            return;

        ApplyEffect(col);
        Destroy(gameObject);
        AudioPlayer.Instance.PlaySound(_audioClip);
    }

    #endregion


    #region Public methods

    public void SetSpeed(float speed)
    {
        _rb.velocity = new Vector2(0, -speed);
    }

    #endregion


    #region Private regions

    protected abstract void ApplyEffect(Collision2D col);

    #endregion
}