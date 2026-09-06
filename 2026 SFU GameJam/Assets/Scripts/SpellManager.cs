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

        Collider2D[] enemies = Physics2D.OverlapCircleAll(spellPos, damageRadius); 
        
        foreach (Collider2D enemy in enemies) 
        {
            if (enemy.CompareTag("Boom"))
            {
                Destroy(enemy);
            }
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
