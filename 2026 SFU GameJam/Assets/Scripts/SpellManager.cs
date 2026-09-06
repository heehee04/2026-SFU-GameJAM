using UnityEngine;

public class SpellManager : MonoBehaviour
{
    public TextInput checkSpell;
    public Vector2 spellPos;

    void CastSpell()
    {
        Debug.Log("nothing happened");
        if (checkSpell.isBoom == true)
        {
            Boom();
        }
        if (checkSpell.isBoom == true)
        {
            Slash();
        }
        if (checkSpell.isBoom == true)
        {
            Zap();
        }
        if (checkSpell.isBoom == true)
        {
            Thump();
        }
        if (checkSpell.isBoom == true)
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

    }
    void Zap()
    {

    }
    void Whoosh()
    {

    }
    void Thump()
    {

    }
}
