using UnityEngine;
using UnityEngine.InputSystem;

public class SpellManager : MonoBehaviour
{
    [SerializeField] private GameObject boomPrefab;
    public TextInput checkSpell;
    public Vector2 spellPos;

    void SpellPos()
    {
        spellPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            spellPos = mousePosition;
            CastSpell();
        }
    }

    public void CastSpell()
    {
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
            Whoosh();
        }
        if (checkSpell.isBoom == true)
        {
            Thump();
        }
    }

    void Boom()
    {
        Debug.Log("casted BOOM");
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
