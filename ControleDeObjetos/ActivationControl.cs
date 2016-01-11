using UnityEngine;
using System.Collections;
/// <summary>
/// Script vai ter a função de ativar ou desativar um determinado objeto atraves de um botão.
/// </summary>
public class ActivationControl : MonoBehaviour {

    bool flag = false;//Sinal
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //Função usada pelo botão para ativar ou desativar um objeto
    public void ACtivation(GameObject Object)
    {
        //Primeiro vamos verificar se o objeto começa ativado ou desativa
        if (Object.active)           //Caso o objeto já esteja ativado
            flag = false;
        else                         //Caso o objeto não esteja ativado
            flag = true;
        //Segundo vamos ATIVAR ou DESATIVAR o objeto usando uma variavel boleana para sabermos se está ativado ou desativado
        if (flag)                    //Caso flag == true
            Object.SetActive(true);
        else                         //Caso flag == false
            Object.SetActive(false);
    }
}
