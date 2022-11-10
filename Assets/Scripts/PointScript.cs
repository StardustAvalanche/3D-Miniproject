using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public int points = 0;
    public TMP_Text pointsUI;

    // Start is called before the first frame update
    void Start()
    {
        pointsUI.text = "Points: " + points;
    }

    public void ResetPoints()
    {
        points = 0;
        pointsUI.text = "Points: " + points;
    }

    public void AddPoint ()
    {
        points++;
        pointsUI.text = "Points: " + points;
    }
}
