using System.Collections;
using UnityEngine;

public class TextBoxColor : MonoBehaviour
{
    public GameObject textbox;
    public float fadeDuration = 1.0f;
    private Renderer boxRenderer;

    void Awake()
    {
        boxRenderer = GetComponent<Renderer>();
    }
    
    public void changeColor()
    {
        if (boxRenderer != null)
        {
            StartCoroutine(FadeOutRoutine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator FadeOutRoutine()
    {
        Color startColor = boxRenderer.material.color;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float  newAlpha = Mathf.Lerp(startColor.a, 0f, elapsedTime / fadeDuration);

            Color newColor = new Color(startColor.r, startColor.g, startColor.b, newAlpha);
            boxRenderer.material.color = newColor;

            yield return null;
        }

        Color finalColor = new Color(startColor.r, startColor.g, startColor.b, 0f);
        boxRenderer.material.color = finalColor;

        gameObject.SetActive(false);
    }
}
