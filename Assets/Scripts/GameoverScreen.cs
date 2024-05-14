using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Text scoreDisplayText;



    private void Start()
    {
        ScoreDisplay();
    }
    private void ScoreDisplay()
    {
        scoreDisplayText.text = "Your Score:" + ScoreManager.skor;
    }
    public void Restart()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
        
    }
}
