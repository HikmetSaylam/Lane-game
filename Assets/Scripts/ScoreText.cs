using TMPro;
using UnityEngine;

public class ScoreText : MonoSingleton<ScoreText>
{
    [SerializeField] private TextMesh scoreTextMesh;
    

    private void Start()
    {
        SetScoreText("1");
    }

    public void SetScoreText(string value)
    {
        scoreTextMesh.text = "Score: " + value;
    }
}
