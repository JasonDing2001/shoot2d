using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthChange : MonoBehaviour
{
    public Text HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = HealthBar.HealthCurrent.ToString() + "/" + "5";
    }
}
