using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class abilityTest : MonoBehaviour
{
    [SerializeField] GameObject ability;
    [SerializeField] GameObject range;

    private void OnMouseDown()
    {
        StartCoroutine(SpawnAbility(mouseLoc()));
    }
    private Vector2 mouseLoc()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }
    IEnumerator SpawnAbility(Vector2 roundPos)
    {
        GameObject aoe = Instantiate(range, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(1.5f);
        Destroy(aoe);
        GameObject abil = Instantiate(ability, roundPos, Quaternion.identity);

        yield return new WaitForSeconds(1.5f);
        Destroy(abil);

    }
}
