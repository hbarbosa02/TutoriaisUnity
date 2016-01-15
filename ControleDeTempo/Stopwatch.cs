using UnityEngine;
using System.Collections;
/// <summary>
/// Classe que vai fazer uma contagem crescente ou decrescente do tempo.
/// </summary>
public class Stopwatch : MonoBehaviour {

    public float TimeInSeconds = 60;//Valor do inicio da contagem ou o final da contagem
    public bool Growing = false;//Verdade(Crescente) falso(Decrescente)

    float Seconds = 0;

    // Use this for initialization
    void Start () {
        if (!Growing)
            Seconds = TimeInSeconds;
	}
	
	// Update is called once per frame
	void Update () {
        _Stopwatch(Growing);
        Debug.Log(Seconds);
	}

    void _Stopwatch(bool flag)
    {
        if(flag)//Crescente
        {
            if (Seconds <= TimeInSeconds)
                Seconds += Time.deltaTime;
            else
                Debug.Log("Fim da contagem");
        }
        else//Decrescente
        {
            if (Seconds >= 0)
                Seconds -= Time.deltaTime;
            else
                Debug.Log("Fim da contagem");
        }
    }
}
