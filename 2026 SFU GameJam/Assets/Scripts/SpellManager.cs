using UnityEngine;

public class SpellManager : MonoBehaviour
{
    public TextInput checkSpell;
    public float spellCooldown;
    public Vector2 spellPos;
    public float damageRadius = 5;

    public bool CanCast => Time.time >= nextCastTime;
    private float nextCastTime;

    void CastSpell()
    {
        if (checkSpell.isBoom == true)
        {
            Boom();
        }
    }

    void Boom()
    {
        if (!CanCast)
        {
            return;
        }
        
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
