using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public static int HealthCurrent;
    public int HealthMax;

    private Image HPBar;

    // Start is called before the first frame update
    void Start()
    {
        HealthCurrent = HealthMax;
        HPBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        HPBar.fillAmount = (float)HealthCurrent / (float)HealthMax;
    }
}
