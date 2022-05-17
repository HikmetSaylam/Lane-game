using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private int speed;
    void Update()
    {
        float x= Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");
        x*=Time.deltaTime*speed;
        z*=Time.deltaTime*speed;
        GetComponent<Rigidbody>().AddForce(x, 0f, z);
    }
}
