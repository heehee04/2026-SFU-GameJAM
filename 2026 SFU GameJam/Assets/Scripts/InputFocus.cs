using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputFocus : MonoBehaviour
{
    public TMP_InputField inputField;

    void Update()
    {
        if (!inputField.isFocused && Input.anyKeyDown && Input.inputString.Length > 0)
        {
            EventSystem.current.SetSelectedGameObject(inputField.gameObject);
            inputField.ActivateInputField();
            inputField.caretPosition = inputField.text.Length;
        }
    }
}
