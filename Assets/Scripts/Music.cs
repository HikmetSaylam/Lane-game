using UnityEngine;

public class Music : MonoBehaviour
{
    private static bool _isThereMusic;
    private void Start()
    {
        if (!_isThereMusic)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            _isThereMusic = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
