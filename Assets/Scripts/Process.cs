using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Process : MonoBehaviour
{
    private TextMeshPro _textMesh;
    private int _operand;
    private int _operator;
    private int _newNumOfPlayers;

    private void Awake()
    {
        this._textMesh = GetComponent<TextMeshPro>();
    }

    private void Start()
    {
        CreatProcess();
    }

    private void CreatProcess()
    {
        this._textMesh.text = "";
        _operator = Random.Range(1, 5);
        _operand = Random.Range(1, 10);
        switch(_operator)
        {
            case 1:
                _textMesh.text += "+" + this._operand.ToString();
                break;
            case 2:
                _textMesh.text += "-" + this._operand.ToString();
                break;
            case 3:
                _textMesh.text += "x" + this._operand.ToString();
                break;
            case 4:
                _textMesh.text += "÷" + this._operand.ToString();
                break;
        }
    }

    private void CalculateNewNumOfPlayers()
    {
        this._newNumOfPlayers = _operator switch
        {
            1 => GameManager.Instance.GetNumOfCharacters() + _operand,
            2 => GameManager.Instance.GetNumOfCharacters() - _operand,
            3 => GameManager.Instance.GetNumOfCharacters() * _operand,
            4 => GameManager.Instance.GetNumOfCharacters() / _operand,
            _ => this._newNumOfPlayers
        };
    }
    public int GetNewNumOfPlayers()
    {
        CalculateNewNumOfPlayers();
        if (this._newNumOfPlayers < 1)
            this._newNumOfPlayers = 1;
        return this._newNumOfPlayers;
    }
}
