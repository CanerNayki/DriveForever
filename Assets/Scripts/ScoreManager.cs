using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text skor_tx;
    public static float skor;
    void Start()
    {
        skor = 0;
    }

    void Update()
    {
        
        skor_tx.text = skor.ToString();
    }
}
