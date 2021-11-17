using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Image imagenFondo;
    public float tiempo = 2.0f;

    private Text texto;

    public void EfectoIn()
    {
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

    public void EfectoText()
    {
        print("Efecto");
        gameObject.SetActive(true);

        texto = gameObject.GetComponent<Text>();
        texto.color = new Color(texto.color.r, texto.color.g, texto.color.b, 1.0f);

        StartCoroutine(FadeOutText());
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

    private IEnumerator FadeOutText()
    {
        texto = GetComponent<Text>();

        while (texto.color.a > 0.0f)
        {
            texto.color = new Color(texto.color.r, texto.color.g, texto.color.b, texto.color.a - (Time.deltaTime / tiempo));
            yield return null;
        }
        if (texto.color.a <= 0.1f)
        {
            gameObject.SetActive(false);
        }
    }

    public void Salir()
    {
        Application.Quit();
    }
}
