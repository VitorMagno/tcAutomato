using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controle : MonoBehaviour
{
    [SerializeField] Image ledDeComando;
    [SerializeField] Material[] ledTextures;
    [SerializeField] Casa casa;
    bool luz1;

    public void BotaoAC()
    {
        PiscarLed();
        casa.ArCondicionado();
    }

    public void BotaoLuz1()
    {
        PiscarLed();
        casa.Interruptor(0);
    }

    public void BotaoLuz2()
    {
        PiscarLed();
        casa.Interruptor(1);
    }

    public void BotaoLuz3()
    {
        PiscarLed();
        casa.Interruptor(2);
    }


    void PiscarLed()
    {
        ledDeComando.material = ledTextures[1];
        Invoke("ApagarLed", 0.1f);
    }

    void ApagarLed()
    {
        ledDeComando.material = ledTextures[0];
    }
}
