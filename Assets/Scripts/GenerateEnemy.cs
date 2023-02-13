using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public static float CreateTime = 1f;

    GameObject virus;
    void Start()
    {
        
    }

    void Update()
    {
        CreateTime -= Time.deltaTime;
        if(CreateTime<=0)
        {
            float i = Random.Range(0f, 1f);
            if (i <= 0.35)
            {
                GameObject obj = (GameObject)Resources.Load("Éä»÷²¡¶¾");
                virus = Instantiate<GameObject>(obj);
                virus.transform.position = new Vector3(13, Random.Range(-3f, 3f), -2);
            }
            else
            {
                GameObject obj = (GameObject)Resources.Load("²¡¶¾");
                virus = Instantiate<GameObject>(obj);
                virus.transform.position = new Vector3(13, Random.Range(-3f, 3f), -2);
            }
            CreateTime = Random.Range(0.5f, 2f);
        }
    }
}
