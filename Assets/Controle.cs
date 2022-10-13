using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controle : MonoBehaviour
{
    [SerializeField] Image[] indicators;
    [SerializeField] Image ledDeComando;
    [SerializeField] Material[] ledTextures;
    [SerializeField] Casa casa;

    private void FixedUpdate()
    {
        int amount = -1;
        foreach (Light luz in casa.luzes)
        {
            if (luz.enabled) amount += 1;
        }

        if (casa.arCondicionado.activeSelf)
        {
            AcenderIndicador(3);
        }
        else if (!(casa.luzes[0].enabled || casa.luzes[1].enabled || casa.luzes[2].enabled || casa.arCondicionado.activeSelf))
        {
            AcenderIndicador(4);
        } 
        else
        {
            AcenderIndicador(amount);
        }
    }

    
    public void Botao(int i)
    {
        PiscarLed();
        casa.Interruptor(i);
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
    void AcenderIndicador(int i)
    {
        for (int x = 0; x < indicators.Length; x++)
        {
            bool ison = x == i ? true : false;
            ChangeColor(ison, x);
        }
    }
    void ChangeColor(bool isOn, int i)
    {
        indicators[i].material = isOn ? ledTextures[1] : ledTextures[0];

    }
}
