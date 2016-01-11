using UnityEngine;
using System.Collections;
/// <summary>
/// O objeto que tiver esse script, quando sair da tela ele sera destruido em 1s, assim limitando o numero
/// de objeto em cena.
/// </summary>
public class ObjectOnScreenControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ScreenLimitation();
	}
    //Função que controla a limitação
    void ScreenLimitation()
    {
        float X = Get_X_Axis();
        float Y = Get_Y_Axis();
        //Condição de Limitação
        if (gameObject.transform.position.x > X || gameObject.transform.position.y > Y ||
            gameObject.transform.position.x < -X || gameObject.transform.position.y < -Y)
        {
            Destroy(gameObject, 1);
        }
    }
    //Função que vai pegar o maxímo da tela no eixo X
    float Get_X_Axis()
    {
        Vector3 vet = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 1, 0));//Pega a maior posição
        return vet.x;
    }
    //Função que vai pegar o maxímo da tela no eixo Y
    float Get_Y_Axis()
    {
        Vector3 vet = Camera.main.ScreenToWorldPoint(new Vector3(1,Screen.height,0));//Pega a maior posição
        return vet.y;
    }
}
