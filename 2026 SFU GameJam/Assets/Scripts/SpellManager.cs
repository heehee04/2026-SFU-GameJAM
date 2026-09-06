using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class SpellManager : MonoBehaviour
{
    [SerializeField] GameObject Range;
    [SerializeField] GameObject boomAbility;
    [SerializeField] GameObject zapAbility;
    [SerializeField] GameObject whooshAbility;
    [SerializeField] GameObject thumpAbility;
    [SerializeField] GameObject slashAbility;

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
        StartCoroutine(SpawnBoom(mouseLoc()));
        checkSpell.isBoom = false;
        checkSpell.ChangeToBlack();
        checkSpell.ResetText();
    }
    void Slash()
    {
        StartCoroutine(SpawnSlash(mouseLoc()));
        Debug.Log("casted SLASH at " + spellPos);
        checkSpell.isSlash = false;
        checkSpell.ChangeToBlack();
    }
    void Zap()
    {
        StartCoroutine(SpawnZap(mouseLoc()));
        Debug.Log("casted ZAP at " + spellPos);
        checkSpell.isZap = false;
        checkSpell.ChangeToBlack();
    }
    void Whoosh()
    {
        Vector3 initialScale = new Vector3(0.5f, 0.5f, 0.5f);
        Vector3 finalScale = new Vector3(5, 5, 5);

        StartCoroutine(SpawnWhoosh(spellPos, 1.5f));
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

    IEnumerator SpawnBoom(Vector2 roundPos)
    {
        GameObject aoe = Instantiate(Range, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.7f);
        Destroy(aoe);
        GameObject abil = Instantiate(boomAbility, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.7f);
        Destroy(abil);
    }
    IEnumerator SpawnSlash(Vector2 roundPos)
    {
        GameObject aoe = Instantiate(Range, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.5f);
        Destroy(aoe);
        GameObject abil = Instantiate(slashAbility, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.7f);
        Destroy(abil);
    }

    IEnumerator SpawnZap(Vector2 roundPos)
    {
        GameObject aoe = Instantiate(Range, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.7f);
        Destroy(aoe);
        GameObject abil = Instantiate(zapAbility, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(0.7f);
        Destroy(abil);
    }

    IEnumerator SpawnWhoosh(Vector2 roundPos, float time)
    {
        GameObject abil = Instantiate(whooshAbility, roundPos, Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        Destroy(abil);
    }
}