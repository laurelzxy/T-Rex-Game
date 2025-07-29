using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public TMP_Text meuTexto; // Arraste seu Text aqui no Inspector
    private float tempo = 0f;

    void Update()
    {
        tempo += Time.deltaTime;

        int segundos = Mathf.FloorToInt(tempo);
        int milissegundos = Mathf.FloorToInt((tempo - segundos) * 1000);

        meuTexto.text = string.Format("{0}:{1:000}", segundos, milissegundos);
    }
}
