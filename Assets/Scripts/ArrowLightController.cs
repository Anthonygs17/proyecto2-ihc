using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLightController : MonoBehaviour
{
    public Light pointLight; // Luz que se enciende
    public SpriteRenderer arrowRenderer; // Sprite Renderer de la flecha
    public float lightChangeSpeed = 2f; // Velocidad de cambio de luz
    public float maxIntensity = 1f; // Intensidad máxima de la luz
    public float minIntensity = 0f; // Intensidad mínima (apagada)

    private float targetIntensity; // Intensidad objetivo
    private Color colorClose = new Color(0.87f, 0.27f, 0.48f); // Color cercano (#DE467B)
    private Color colorFar = Color.black; // Color lejano (#000000)

    private void Start()
    {
        if (pointLight != null)
        {
            pointLight.intensity = minIntensity; // Comienza apagada
            targetIntensity = minIntensity;
        }

        if (arrowRenderer != null)
        {
            arrowRenderer.color = colorFar; // Comienza con el color lejano
        }
    }

    private void Update()
    {
        if (pointLight != null)
        {
            // Interpolación suave hacia la intensidad objetivo
            pointLight.intensity = Mathf.Lerp(pointLight.intensity, targetIntensity, Time.deltaTime * lightChangeSpeed);
        }

        if (arrowRenderer != null)
        {
            // Interpolación suave entre el color cercano y el lejano
            Color targetColor = targetIntensity > 0 ? colorClose : colorFar;
            arrowRenderer.color = Color.Lerp(arrowRenderer.color, targetColor, Time.deltaTime * lightChangeSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetIntensity = maxIntensity; // Enciende la luz y cambia el color al acercarse
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetIntensity = minIntensity; // Apaga la luz y cambia el color al alejarse
        }
    }
}
