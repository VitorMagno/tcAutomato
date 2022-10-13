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
    List<int> historico = new List<int>();  

    private void Update()
    {
        if (!(casa.luzes[0].enabled || casa.luzes[1].enabled || casa.luzes[2].enabled || casa.arCondicionado.activeSelf))
        {
            AcenderIndicador(4);
        }
    }

    
    public void Botao(int i)
    {
        PiscarLed();
        if (casa.Interruptor(i))
        {
            AcenderIndicador(i);
            historico.Add(i);
        }
        else if (historico.Count > 1)
        {
            historico.RemoveAt(historico.Count - 1);
            AcenderIndicador(historico[historico.Count - 1]);
        }
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
