using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.tag.Equals("Character")) return;
        SceneManager.LoadScene("StartScene");
    }
}
