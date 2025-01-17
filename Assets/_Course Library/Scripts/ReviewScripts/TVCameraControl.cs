using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TVCameraControl : MonoBehaviour
{
    [Header("UIText")]
    public TextMeshProUGUI scoreDisplay;

    [Header("Scripts")]
    public GameManager gm;
   
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void UpdateTVScreen()
    {
        gm.UpdateDisplay();
    }
   
}
