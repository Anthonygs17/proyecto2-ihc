using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Material _lens;

    public Light __light;
    public AudioSource __audioSource;
    // Start is called before the first frame update
    void Start()
    {
        __light = GetComponent<Light>();
        __audioSource = GetComponent<AudioSource>();
    }

    public void _LightOn()
    {
        __audioSource.Play();
        _lens.EnableKeyword("_EMISSION");
        __light.enabled = true;
    }

    public void _LightOff()
    {
        __audioSource.Play();
        _lens.DisableKeyword("_EMISSION");
        __light.enabled = false;
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Material lens;

    private Light _light;
    private AudioSource _audioSource;

    private bool _isLightOn = true; // Estado inicial de la linterna
    private ParticleSystem _particleSystem; // Referencia al sistema de partículas

    // Rango de tiempo aleatorio para apagones y encendidos
    public float minOffTime = 2f; // Tiempo mínimo apagada
    public float maxOffTime = 5f; // Tiempo máximo apagada
    public float minOnTime = 3f;  // Tiempo mínimo encendida
    public float maxOnTime = 8f;  // Tiempo máximo encendida

    void Start()
    {
        _light = GetComponentInChildren<Light>();
        _audioSource = GetComponent<AudioSource>();

        // Iniciar la rutina que controla los apagones
        StartCoroutine(HandleFlickering());
        // Buscar el sistema de partículas en los hijos de este objeto
        _particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    private IEnumerator HandleFlickering()
    {
        while (true)
        {
            if (_isLightOn)
            {
                // Apagar la linterna después de un tiempo aleatorio
                yield return new WaitForSeconds(Random.Range(minOnTime, maxOnTime));
                LightOff();
            }
            else
            {
                // Encender la linterna después de un tiempo aleatorio
                yield return new WaitForSeconds(Random.Range(minOffTime, maxOffTime));
                LightOn();
            }
        }
    }

    public void LightOn()
    {
        _audioSource.Play();
        lens.EnableKeyword("_EMISSION");
        _light.enabled = true;
        _isLightOn = true;

        // Activar partículas si el sistema existe
        if (_particleSystem != null && !_particleSystem.isPlaying)
        {
            _particleSystem.Play();
        }
    }

    public void LightOff()
    {
        _audioSource.Play();
        lens.DisableKeyword("_EMISSION");
        _light.enabled = false;
        _isLightOn = false;

        // Detener partículas si el sistema existe
        if (_particleSystem != null && _particleSystem.isPlaying)
        {
            _particleSystem.Stop();
        }
    }
}
*/