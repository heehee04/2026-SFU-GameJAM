using UnityEngine;

public class TextInput : MonoBehaviour
{

    private string text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextInputCheck(string s)
    {
        text = s;
        Debug.Log(text);
    }
}
