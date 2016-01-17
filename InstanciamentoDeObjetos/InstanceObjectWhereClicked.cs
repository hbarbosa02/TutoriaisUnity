using UnityEngine;
using System.Collections;

public class InstanceObjectWhereClicked : MonoBehaviour {

    public GameObject Object;//Objeto que vai ser instanciado

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Condição para o instanciamento
        if (Input.GetMouseButtonDown(0)) 
        { 
        	InstanceObject(); 
        	
        }
	}
    //Função que vai instanciar o objeto na posição que for clicado na tela
    void InstanceObject()
    {
        //Pega a posição do mouse em 2D
        Vector2 vet = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Instancia o objeto na posição "vet"
        Instantiate(Object,vet,Quaternion.identity);
    }
}
