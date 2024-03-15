using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeText : MonoBehaviour
{
    public float fadeDuration = 3f; // Duration of the fade
    private Text textComponent;
    private CanvasGroup canvasGroup;

    void Start()
    {
        textComponent = GetComponent<Text>();
        canvasGroup = GetComponent<CanvasGroup>();

        // Start the fading process
        Invoke("FadeOut", fadeDuration);
    }

    void FadeOut()
    {
        // Fade out the text
        StartCoroutine(FadeOutRoutine());
    }

    IEnumerator FadeOutRoutine()
    {
        float elapsedTime = 0f;
        float startAlpha = canvasGroup.alpha;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 0f, elapsedTime / fadeDuration);
            yield return null;
        }

        // Ensure alpha is exactly 0 at the end
        canvasGroup.alpha = 0f;
    }
}