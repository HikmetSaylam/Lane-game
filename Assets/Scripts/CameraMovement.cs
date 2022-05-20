using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    private Transform _transformPlayer;
    private Vector3 _offSet;
    private void Awake()
    {
        _transformPlayer = GameObject.FindWithTag("Character").GetComponent<Transform>();
        _offSet = transform.position - _transformPlayer.position;
    }

    void Update()
    {
        transform.position = _transformPlayer.transform.position + _offSet;
    }
}
