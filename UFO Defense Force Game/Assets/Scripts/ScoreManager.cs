using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
   public int score; // Keeps our score value
   public TextMeshProUGUI scoreText; // Visual text element to be modified

   public void IncreaseScore(int amount) // This method when called increases the score by a predetermind amount set in score variable
   {
    score += amount;
    UpdateScoreText();

   }

   public void DecreaseScore(int amount) // This method when called decrease the score by a predetermind amount set in score variable
   {
    score -= amount;
    UpdateScoreText();
   }

   public void UpdateScoreText()
   {
    scoreText.text = "Score: "+ score;
   }
}
