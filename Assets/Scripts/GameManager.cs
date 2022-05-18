using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    private int _numOfPlayer;
    private Queue<GameObject> players = new Queue<GameObject>();
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public int GetNumOfPlayer()
    {
        return this._numOfPlayer;
    }

    public void SetNumOfPlayer(int value)
    {
        this._numOfPlayer = value;
    }

    public void AddPlayer(GameObject player)
    {
        players.Enqueue(player);
    }

    public void RemovePlayer()
    {
        players.Dequeue();
    }
}
