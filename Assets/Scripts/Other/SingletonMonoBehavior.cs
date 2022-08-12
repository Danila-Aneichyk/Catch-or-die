using UnityEngine;

public class SingletonMonoBehavior<T> : MonoBehaviour
{
    #region Variables

    private static T _instance;
    public GameObject GameObject;

    #endregion


    #region Properties

    public static T Instance => _instance;

    #endregion


    #region Unity lifecycle

    protected virtual void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = (GameObject = gameObject).GetComponent<T>();
        DontDestroyOnLoad(GameObject);
    }
}

#endregion