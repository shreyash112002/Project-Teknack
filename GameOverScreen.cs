using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    
public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "POINTS";
        
    }
    public static void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }
    public static void ExitButton()
    {
        SceneManager.LoadScene("MenuPage");
    }
}
