using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoSingleton<GameManager>
{
    private int _numOfPlayer = 1;
    private readonly Queue<GameObject> _players = new Queue<GameObject>();
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject character;
    

    public int GetNumOfPlayer()
    {
        return this._numOfPlayer;
    }
    public void AddPlayer()
    {
        var go = player;
        Instantiate(go, character.transform.position, Quaternion.Euler(0, 0, 0));
        _players.Enqueue(go);
        this._numOfPlayer++;
    }

    public void RemovePlayer()
    {
        var go = _players.Peek();
        _players.Dequeue();
        Destroy(go);
        this._numOfPlayer--;
    }
}
