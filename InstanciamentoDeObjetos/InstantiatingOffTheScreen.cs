using UnityEngine;
using System.Collections;
/// <summary>
/// Instancia os Objetos Fora da Tela
/// </summary>
public class InstantiatingOffTheScreen : MonoBehaviour {

    public GameObject Object;

    bool flag = true;//Variavel que vai ser usada para trocar as condições
    int count = 0;//Variavel de apoio

    int aux = 1;//Variavel que vai multiplicar o tamanho da tela para ficar mudando o sinal

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Instantiating();
	}
    //Instancia os objetos
    void Instantiating()
    {
        //Primeira condição instancia no eixo Y
        if (flag && count == 0)
        {
            Instantiate(Object, new Vector2(aux * (ScreenSize().x + 1), Random.Range(-ScreenSize().y, ScreenSize().y)), Quaternion.identity);
            flag = false;
            count += 1;
        }
        //Segunda condição instancia no eixo X
        else if (!flag && count == 1)
        {
            Instantiate(Object, new Vector2(Random.Range(-ScreenSize().x, ScreenSize().x), aux * (ScreenSize().y + 1)),Quaternion.identity);
            flag = true;
            count += 1;
        }
        //Muda o sinal
        else if(flag && count == 2)
        {
            count = 0;
            aux *= (-1);//Muda o sinal para inverter a posição na tela
        }
    }
    //Retorna o Tamonho no eixo x e y da tela
    Vector3 ScreenSize()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0));
    }
}
