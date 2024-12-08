using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Cube : MonoBehaviour
{
    public Material lens;
    public ParticleSystem particles;
    private float contador = 0;
    public GameObject objetoAparecer;

    private Light _light;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _light = GetComponentInChildren<Light>();
        _audioSource = GetComponent<AudioSource>();

        particles.Stop();
        objetoAparecer.SetActive(false);
    }

    void Update()
    {
        if (contador == 1)
        {
            objetoAparecer.SetActive(true);
        }
    }

    public void LightOn()
    {
        _audioSource.Play();
        lens.EnableKeyword("_EMISSION");
        _light.enabled = true;
        contador = 1f;

        particles.Play();
    }

    public void LightOff()
    {
        _audioSource.Play();
        lens.DisableKeyword("_EMISSION");
        _light.enabled = false;
        particles.Stop();
    }
}
