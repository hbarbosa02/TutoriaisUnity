using UnityEngine;
using System.Collections;

public class ChasingTheTarget : MonoBehaviour {

    public Vector2 _target;//Alvo
    public float _speed = 5;//velocidade do movimento

    // Use this for initialization
	void Start () {
        _speed *= Time.deltaTime;//Normaliza a Velocidade
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    //Função que faz o objeto se mover na direção do alvo
    void Move()
    {
        //Condição de movimento
        if(_target != null)
        {
            //Move o objeto que possua esse script para o alvo
            gameObject.transform.position = Vector3.MoveTowards(transform.position, _target, _speed);
        }
    }
}
