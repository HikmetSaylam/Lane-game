using UnityEngine;
public class Door : MonoBehaviour
{
   
    private int _newNumPlayers;
    [SerializeField] private GameObject text;
    private Process _process;

    private void Awake()
    {
        _process = text.GetComponent<Process>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.tag.Equals("Character")) return;
        this._newNumPlayers = _process.GetNewNumOfPlayers();
        if (GameManager.Instance.GetNumOfCharacters() > this._newNumPlayers)
        {
            while (GameManager.Instance.GetNumOfCharacters() != this._newNumPlayers)
            {
                GameManager.Instance.RemovePlayer();
            }
        }
        else
        {
            while (GameManager.Instance.GetNumOfCharacters() != this._newNumPlayers)
            {
                GameManager.Instance.AddPlayer(other.transform);
            }
        }
    }
}

