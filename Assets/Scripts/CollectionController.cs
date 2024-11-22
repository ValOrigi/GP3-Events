using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectionController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;
    private int score;

    public void AddScore()
    {
        score++;
        scoreUI.text = "Score: " + score.ToString();
    }
}
