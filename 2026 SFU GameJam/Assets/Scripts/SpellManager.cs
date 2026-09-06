using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class SpellManager : MonoBehaviour
{
    [SerializeField] GameObject boomAbility;
    [SerializeField] GameObject boomRange;

    public TextInput checkSpell;
    public Vector2 spellPos;

    private Vector2 mouseLoc()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

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
        StartCoroutine(SpawnAbility(mouseLoc()));
        checkSpell.isBoom = false;
        checkSpell.ChangeToBlack();
    }
    void Slash()
    {
        Debug.Log("casted SLASH at " + spellPos);
        checkSpell.isSlash = false;
        checkSpell.ChangeToBlack();
    }
    void Zap()
    {
        Debug.Log("casted ZAP at " + spellPos);
        checkSpell.isZap = false;
        checkSpell.ChangeToBlack();
    }
    void Whoosh()
    {
        Debug.Log("casted WHOOSH at " + spellPos);
        checkSpell.isWhoosh = false;
        checkSpell.ChangeToBlack();
    }
    void Thump()
    {
        Debug.Log("casted THUMP at " + spellPos);
        checkSpell.isThump = false;
        checkSpell.ChangeToBlack();
    }

    IEnumerator SpawnAbility(Vector2 roundPos)
    {
        GameObject aoe = Instantiate(boomRange, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.7f);
        Destroy(aoe);
        GameObject abil = Instantiate(boomAbility, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.7f);
        Destroy(abil);

    }
}