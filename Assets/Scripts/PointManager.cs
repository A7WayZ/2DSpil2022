using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int Point = 0;
    public TextMeshProUGUI PointText;

    public void AddPoint(int amount)
    {
        Point += amount;
        PointText.text = "Point: " + Point;
    }
}
