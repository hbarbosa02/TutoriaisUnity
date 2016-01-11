using UnityEngine;
using System.Collections;
/// <summary>
/// rotacionar o objeto para posição que foi clicada na tela
/// </summary>
public class RotateObject : MonoBehaviour {

    float discrepancy = 90; // Correção do angulo, talvez precise ajustar o valor

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        rotateObject();//Coloca a função em execução
	}

    //Rotaciona o objeto para posição clicada na tela
    void rotateObject()
    {
        //Condição para rotação
        if (Input.GetMouseButtonDown(0))
        {
            //Rotaciona o objeto que tiver esse script para direção clicada na tela
            gameObject.transform.eulerAngles = new Vector3(0,0,(discrepancy + catchMousePosition()));
        }
    }
    //Pega a posição que foi clicada na tela e tranforma em radiano para RotateObject rotacionar o objeto
    float catchMousePosition()
    {
        //Primeiro Pegar a posição
        Vector3 _pos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //Segundo Transforma a posição anterior em radiano
        float rotation = Mathf.Atan2(_pos.y, _pos.x) * Mathf.Rad2Deg;
        return rotation;
    }
}
