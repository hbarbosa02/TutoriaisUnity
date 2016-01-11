using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	//Função para ter Acesso a um link qualquer da web
    public void webLink(string Link)
    {
        Application.OpenURL(Link);
    }
    //função para mudar de cena no seu aplicativo
    public void SceneChange(string Scene)
    {
        Application.LoadLevel(Scene);
    }
}
