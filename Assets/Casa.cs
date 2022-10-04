using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casa : MonoBehaviour
{
    [SerializeField] Light[] luzes;
    [SerializeField] GameObject arCondicionado;

    AudioSource audioSource;
    [SerializeField] AudioClip ACbeep;
    [SerializeField] AudioClip lightSwitch;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public bool Interruptor(int i)
    {
        audioSource.PlayOneShot(lightSwitch);
        luzes[i].enabled = !luzes[i].enabled;
        return luzes[i].enabled;
    }

    public bool ArCondicionado()
    {
        audioSource.PlayOneShot(ACbeep);
        arCondicionado.SetActive(!arCondicionado.activeSelf);
        return arCondicionado.activeSelf;
    }
}
