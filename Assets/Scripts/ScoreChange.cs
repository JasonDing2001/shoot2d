using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    public static int Score_num = 0;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {

        Score_num = 0;
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "SCORE:" + Score_num.ToString();
        PlayerPrefs.SetString("SCORE", Score_num.ToString());
    }
}
