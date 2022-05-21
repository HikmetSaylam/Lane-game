using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private float leftWall;
    [SerializeField] private float rightWall;
    private void FixedUpdate()
    {
        var x= Input.GetAxis("Horizontal");
        x *= speed;
        GetComponent<Rigidbody>().velocity = new Vector3(x, 0,  speed);
        var pos = transform.position;
        pos.x =  Mathf.Clamp(pos.x, leftWall, rightWall);
        transform.position = pos;
    }
}
