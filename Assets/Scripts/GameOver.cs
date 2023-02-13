using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float HoldOnTime = 1f;
    static bool Flag;
    public static void changeFlag()
    {
        Flag = true;
    }
    private void Start()
    {
        Flag = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Flag)
        { HoldOnTime -= Time.deltaTime;}

        if (HoldOnTime <= 0)
            SceneManager.LoadScene("GameOver");
        
    }
}
