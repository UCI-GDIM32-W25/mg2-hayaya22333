using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointText : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;

    void Start()
    {
        UpdatePointText(0);
    }
    public void UpdatePointText(int _point)
    {
        pointsText.text = "Points: " + _point.ToString();
    }
}
