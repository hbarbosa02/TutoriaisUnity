using UnityEngine;
using System.Collections;

public class InstancingOutOutOffScreen : MonoBehaviour {
    public GameObject Object;
    public Vector2 XY_Max;
    bool flag = true;
    int count = 0;
    int x = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Instanci1();
        //Instanci2();
    }
    void Instanci1()
    {
        if(flag && count == 0)
        {
            flag = false;
            count++;
            Instantiate(Object,new Vector2(x * Random.Range(-ScreenSize().x, ScreenSize().x), x * (ScreenSize().y)),Quaternion.identity);
        }
        else if(!flag && count == 1)
        {
            flag = true;
            count++;
            Instantiate(Object, new Vector2(x * (ScreenSize().x + 1), x * Random.Range(-ScreenSize().y, ScreenSize().y)), Quaternion.identity);
        }
        else if(flag && count == 2)
        {
            count = 0;
            x *= (-1);
        }
    }
    void Instanci2()
    {
        if (flag && count == 0)
        {
            flag = false;
            count++;
            Instantiate(Object, new Vector2(x * XY_Max.x, x * Random.Range(-XY_Max.y, XY_Max.y)), Quaternion.identity);
        }
        else if(!flag && count == 1)
        {
            flag = true;
            count++;
            Instantiate(Object, new Vector2(x * Random.Range(-XY_Max.x, XY_Max.x), x * XY_Max.y), Quaternion.identity);
        }
        else if(flag && count == 2)
        {
            count = 0;
            x *= (-1);
        }
    }
    Vector2 ScreenSize()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }
}
