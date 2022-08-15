using UnityEngine;
using Random = UnityEngine.Random;

public class PickUpsFalls : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameObject[] _pickUpsArray;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        InvokeRepeating("SpawnPickUps", 1, 4);
    }

    #endregion


    #region Private methods

    private void SpawnPickUps()
    {
        int randomNumber = Random.Range(0, _pickUpsArray.Length);
        Instantiate(_pickUpsArray[randomNumber], new Vector3(Random.Range(-2.8f, 2.8f), 4, 0.1f), Quaternion.identity);
    }

    #endregion
}