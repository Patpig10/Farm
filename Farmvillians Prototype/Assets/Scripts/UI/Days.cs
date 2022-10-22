using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Days : MonoBehaviour
{
    public TMP_Text Day;
    public static int days = 1;


    // Start is called before the first frame update
    public void canlender()
    {
        days++;
        Day.text = "Days: " + days;
    }
    private void Update()
    {
        Day.text = "Days: " + days;
    }
}
