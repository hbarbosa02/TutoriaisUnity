using UnityEngine;
using System.Collections;
/// <summary>
/// Instancia objetos dentro da tela aleatóriamente, no intervalo de tempo determinado.
/// </summary>
public class InstancingRandom : MonoBehaviour {

    public GameObject Object;//Objeto a ser instanciado
    public float Delay = 2;//Tempo de espera para instanciar

    float cont = 0;//contador

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        cont += Time.deltaTime; //Incrementando o contador por frame
        //Condição do instanciamento
        if(cont > Delay)
        {
            Instancing();
            cont = 0;//Zera o contador sempre que instanciar um objeto
        }
	}
    //Função que instancia o objeto
    void Instancing()
    {
        float X_Size = ScreenSize().x;
        float Y_Size = ScreenSize().y;
        //Random.Range(Min,Max)-Retorna um numero aleatorio entre o minimo e o maximo informados
        Instantiate(Object,new Vector2(Random.Range(-X_Size,X_Size), Random.Range(-Y_Size,Y_Size)),Quaternion.identity);
    }
    //Função que retorno o tamanho maximo da tela
    Vector3 ScreenSize()
    {
        return Camera.main.ScreenToWorldPoint( new Vector3(Screen.width, Screen.height, 0));
    }
}
