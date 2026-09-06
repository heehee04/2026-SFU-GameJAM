using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursorDefault;
    [SerializeField] private Vector2 clickPos = Vector2.zero;

    public TextInput checkSpell;

    private void Start()
    {
        //checkSpell.GetComponent<GameObject>();
        Cursor.SetCursor(cursorDefault, clickPos, CursorMode.Auto);
    }

    public void CheckSpell()
    {
        if (checkSpell.isBoom == true)
        {
            Debug.Log("cursor change");
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