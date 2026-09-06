using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursorDefault;
    [SerializeField] private Texture2D cursorSpell;
    [SerializeField] private Vector2 clickPos = Vector2.zero;
    public TextInput checkSpell;

    private void Start()
    {
        Cursor.SetCursor(cursorDefault, clickPos, CursorMode.Auto);
    }

    public void CheckSpell()
    {
        if (checkSpell.isBoom == true)
        {
            Cursor.SetCursor(cursorSpell, clickPos, CursorMode.Auto);
        }
        if (checkSpell.isSlash == true)
        {
            Debug.Log("cursor change");
        }
        if (checkSpell.isZap == true)
        {
            Debug.Log("cursor change");
        }
        if (checkSpell.isWhoosh == true)
        {
            Debug.Log("cursor change");
        }
        if (checkSpell.isThump == true)
        {
            Debug.Log("cursor change");
        }
    }

}