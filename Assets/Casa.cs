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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Interruptor(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) Interruptor(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) Interruptor(2);
        if (Input.GetKeyDown(KeyCode.Alpha4)) ArCondicionado();
    }

    public void Interruptor(int i)
    {
        audioSource.PlayOneShot(lightSwitch);
        luzes[i].enabled = !luzes[i].enabled;
    }

    public void ArCondicionado()
    {
        audioSource.PlayOneShot(ACbeep);
        arCondicionado.SetActive(!arCondicionado.activeSelf);
    }
}
