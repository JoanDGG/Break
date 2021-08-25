using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Image imagenFondo;
    public float tiempo = 2.0f;
    
    public void EfectoIn()
    {
        tiempo = 1.0f;
        gameObject.SetActive(true);
        imagenFondo.canvasRenderer.SetAlpha(0f);
        imagenFondo.CrossFadeAlpha(1, tiempo, false);
        StartCoroutine(EsperarFadeIn());
    }

    public void EfectoOut()
    {
        imagenFondo.canvasRenderer.SetAlpha(1f);
        imagenFondo.CrossFadeAlpha(0, tiempo, false);
        StartCoroutine(EsperarFadeOut());
    }

    public IEnumerator EsperarFadeOut()
    {
        yield return new WaitForSeconds(tiempo);
        gameObject.SetActive(false);
    }

    public IEnumerator EsperarFadeIn()
    {
        yield return new WaitForSeconds(tiempo);
    }
}
