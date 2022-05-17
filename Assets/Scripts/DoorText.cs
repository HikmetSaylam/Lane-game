using UnityEngine;

public class DoorText : MonoBehaviour
{
    private TextMesh _textMesh;

    private void Awake()
    {
        _textMesh=GetComponent<Transform>().Find("text").gameObject.GetComponent("TextMesh")as TextMesh;
    }

    public void SetTextMesh(string value)
    {
        _textMesh.text = value;
    }
}
