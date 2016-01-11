using UnityEngine;
using System.Collections;
/// <summary>
/// Movimenta com o mouse precionado ou quando clicar na tela do celular.
/// </summary>
public class MoveTheMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Condição do Movimento
        if(Input.GetMouseButton(0))
        { Movement(); }
	}
    //Função do Movimento
    void Movement()
    {
        //A posição do objeto que tiver esse escript como componente, passa a ser a posição do mouse.
        gameObject.transform.position = Input.mousePosition;
    }
}
