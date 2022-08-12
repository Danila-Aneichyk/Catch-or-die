using UnityEngine;

public class Pad : MonoBehaviour
{
    #region Variables

    private bool _isStarted;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        
    }

    private void Update()
    {
        Vector3 mousePositionInPixels = Input.mousePosition;
        Vector3 mousePositionInUnits = Camera.main.ScreenToWorldPoint(mousePositionInPixels);

        Vector3 currentPosition = transform.position;
        currentPosition.x = mousePositionInUnits.x;
        transform.position = currentPosition;
    }

    #endregion


    #region Private methods

    private void StartMove()
    {
        _isStarted = true;
    }

    #endregion
}