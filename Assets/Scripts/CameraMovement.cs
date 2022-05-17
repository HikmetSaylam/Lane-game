using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    private Transform _transformPlayer;

    private void Awake()
    {
        _transformPlayer = GameObject.FindWithTag("Character").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = _transformPlayer.transform.position + new Vector3(0, 3, -5);
    }
}
