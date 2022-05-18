using UnityEngine;
using Random = UnityEngine.Random;

public class Process : MonoBehaviour
{
    private string _message;
    private int _operand;
    private int _operator;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    
    public void CreatProcess()
    {
        _operand = Random.Range(1, 4);
        _operator = Random.Range(1, 10);
        switch(_operand)
        {
            case 1:
                _message += "+" + this._operator.ToString();
                GameManager.Instance.SetNumOfPlayer(GameManager.Instance.GetNumOfPlayer()+this._operator);
                break;
            case 2:
                _message += "-" + this._operator.ToString();
                GameManager.Instance.SetNumOfPlayer(GameManager.Instance.GetNumOfPlayer()-this._operator);
                break;
            case 3:
                _message += "*" + this._operator.ToString();
                GameManager.Instance.SetNumOfPlayer(GameManager.Instance.GetNumOfPlayer()*this._operator);
                break;
            case 4:
                _message += "÷" + this._operator.ToString();
                GameManager.Instance.SetNumOfPlayer(GameManager.Instance.GetNumOfPlayer()/this._operator);    
                break;
        }
    }
}
