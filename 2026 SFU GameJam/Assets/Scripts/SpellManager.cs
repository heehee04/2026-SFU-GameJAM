using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class SpellManager : MonoBehaviour
{
    public TextInput checkSpell;
    public Vector2 spellPos;

    public void OnMouseDown()
    {
        CastSpell();
    }

    void CastSpell()
    {
        if (checkSpell.isBoom == true)
        {
            Boom();
        }
        if (checkSpell.isSlash == true)
        {
            Slash();
        }
        if (checkSpell.isZap == true)
        {
            Zap();
        }
        if (checkSpell.isThump == true)
        {
            Thump();
        }
        if (checkSpell.isWhoosh == true)
        {
            Whoosh();
        }
    }

    void Boom()
    {
        Debug.Log("casted BOOM at " + spellPos);
        checkSpell.isBoom = false;
    }
    void Slash()
    {
        Debug.Log("casted SLASH at " + spellPos);
        checkSpell.isSlash = false;
    }
    void Zap()
    {
        Debug.Log("casted ZAP at " + spellPos);
        checkSpell.isZap = false;
    }
    void Whoosh()
    {
        Debug.Log("casted WHOOSH at " + spellPos);
        checkSpell.isWhoosh = false;
    }
    void Thump()
    {
        Debug.Log("casted THUMP at " + spellPos);
        checkSpell.isThump = false;
    }
}
