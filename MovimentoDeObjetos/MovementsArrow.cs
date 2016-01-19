using UnityEngine;
using System.Collections;
/// <summary>
/// Funciona com As setas do Teclado:
/// </summary>
public class MovementsArrow : MonoBehaviour
{
    public float _speed = 5;//Valor da Velocidade

    // Use this for initialization
    void Start()
    {
        _speed *= Time.deltaTime;//Normalizando a Velocidade
    }

    // Update is called once per frame
    void Update()
    {
        //Condição do Movimento
        if (Input.GetKey(KeyCode.UpArrow))
        { Up(); }
        else if(Input.GetKey(KeyCode.DownArrow))
        { Down(); }
        else if(Input.GetKey(KeyCode.LeftArrow))
        { Left(); }
        else if(Input.GetKey(KeyCode.RightArrow))
        { Right(); }
    }
    //Funções para o movimento
    //Para Cima
    public void Up() {
        Debug.Log("Up");
            gameObject.transform.Translate(new Vector3(0, _speed, 0));
    }
    //Para Baixo
    public void Down() {
        Debug.Log("Down");
        gameObject.transform.Translate(new Vector3(0, -_speed, 0));
    }
    //Para Esquerda
    public void Left() {
        Debug.Log("Left");
        gameObject.transform.Translate(new Vector3(-_speed, 0, 0));
    }
    //Para Direita
    public void Right() {
        Debug.Log("Right");
        gameObject.transform.Translate(new Vector3(_speed, 0, 0));
    }
}
