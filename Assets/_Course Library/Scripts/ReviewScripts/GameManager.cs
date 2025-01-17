using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [Header("UIText")]
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI waveCounter;

    [Header("Ints")]
    public int score;
    public int waves;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        waves = 1;
    }

    // Update is called once per frame
   
    public void AddToScore()
    {
        score++;
        UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        scoreDisplay.text = $"Score: {score}";
    }
}
