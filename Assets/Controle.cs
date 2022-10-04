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
        
    }

    public void BotaoLuz1()
    {
        
    }

    public void BotaoLuz2()
    {
        
    }

    public void BotaoLuz3()
    {

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
