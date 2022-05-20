using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    private int _numOfCharacters = 1;
    private List<GameObject> _players = new List<GameObject>();
    [SerializeField] private GameObject player;
    

    public int GetNumOfCharacters()
    {
        return this._numOfCharacters;
    }
    public void AddPlayer(Transform parent)
    {
        var go = player;
        var obje = Instantiate(go, transform.position, Quaternion.Euler(0, 0, 0));
        obje.transform.parent = parent;
        obje.transform.localPosition = new Vector3(0,0,(parent.childCount - 1) * -1.1f);
        _players.Add(obje);
        this._numOfCharacters++;
    }

    public void RemovePlayer()
    {
        var obje = _players.Last();
        _players.Remove(obje);
        Destroy(obje);
        this._numOfCharacters--;
    }
}
