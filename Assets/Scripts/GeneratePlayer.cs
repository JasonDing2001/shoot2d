using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlayer : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("Íæ¼Ò·É´¬");
        Player = Instantiate<GameObject>(obj);
        Player.transform.position = new Vector3(-5, 0, -2);
    }
}
