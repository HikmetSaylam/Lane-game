using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private int speed;
    private void FixedUpdate()
    {
        var x= Input.GetAxis("Horizontal");
        x *= speed;
        GetComponent<Rigidbody>().velocity = new Vector3(x, 0,  speed);
        var pos = transform.position;
        pos.x =  Mathf.Clamp(pos.x, -4.2f, 5f);
        transform.position = pos;
    }
}
