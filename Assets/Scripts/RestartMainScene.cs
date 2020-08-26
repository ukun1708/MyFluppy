using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartMainScene : MonoBehaviour
{
    public Text txt;
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    private void Start()
    {
        txt.text = "Ваш рекорд: " + Score.maxScore.ToString() + "\nТекущий счет: " + Score.lastScore.ToString();

        if (Score.maxScore == Score.lastScore)
        {
            if (Score.maxScore > 0)
            {
                txt.text += "\nПоздравляем новый рекорд";
            }
            
        }

    }

}
