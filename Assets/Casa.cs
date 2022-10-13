using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casa : MonoBehaviour
{
    [SerializeField] public Light[] luzes;
    [SerializeField] public GameObject arCondicionado;

    AudioSource audioSource;
    [SerializeField] AudioClip ACbeep;
    [SerializeField] AudioClip lightSwitch;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public bool Interruptor(int i)
    {
        if (i == 3)
        {
            audioSource.PlayOneShot(ACbeep);
            arCondicionado.SetActive(!arCondicionado.activeSelf);
            return arCondicionado.activeSelf;
        }
        audioSource.PlayOneShot(lightSwitch);
        luzes[i].enabled = !luzes[i].enabled;
        return luzes[i].enabled;
    }

}
