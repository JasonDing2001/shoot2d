using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        score.text = "YOUR SCORE:" + PlayerPrefs.GetString("SCORE");
    }
}
