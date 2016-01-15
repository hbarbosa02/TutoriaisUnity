using UnityEngine;
using System.Collections;
/// <summary>
/// Esse script vai fazer com que o objeto que o tenha, 
/// dure apenas um tempo ou até ele atingir um outro objeto na tela.
/// 
/// Objeto vai ser destruido quando colidir com outro objeto qualquer
/// </summary>
public class KamikazeObject : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
    //Indentifica uma colisão com outro objeto
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 0);// Destroi o gameObject que tiver esse script em 0 segundos.
    }
}
