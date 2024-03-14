using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Generator : MonoBehaviour
{
    public TMP_Text t;
    public TMP_Text Score;
    public float count = 0;

    public GameObject p;
    public GameObject vs;
    public GameObject o;

    public Image i;
    public Image player;
    
    public string[] preference;
    public Sprite Rock, Paper, Scissors;

    public Sprite trophySprite; // Drag your trophy sprite here in the Inspector
    public Sprite losingSprite; // Drag your losing sprite here in the Inspector

    public Image Image1; // Drag your Image component here in the Inspector
    public Image Image2; // Drag your Image component here in the Inspector

    public void game(string  mypref)
    {
        p.SetActive(true);
        vs.SetActive(true);
        o.SetActive(true);

        string randomGen = preference[Random.Range(0, preference.Length)];
        
        //switch case for randomly generating stone paper or scissors for computer
        switch(randomGen)
        {
            case "Rock":
                switch(mypref)
                {
                    case "Rock":
                    t.text = "It's a Draw!";
                    player.sprite = Rock;
                    DisableImage();
                    break;

                    case "Paper":
                    t.text = "You win!";
                    player.sprite = Paper;
                    count = count+1;
                    ChangeToTrophySprite();
                    break;

                    case "Scissors":
                    t.text = "You lose!";
                    player.sprite = Scissors;
                    ChangeToLosingSprite();
                    break;

                }
                //Debug.Log(count);
                Score.SetText("Score : "+count.ToString());
                i.sprite = Rock;
                break;

            case "Paper":
                switch(mypref)
                {
                    case "Rock":
                    t.text = "You lose!";
                    player.sprite = Rock;
                    ChangeToLosingSprite();
                    break;

                    case "Paper":
                    t.text = "It's a Draw!";
                    player.sprite = Paper;
                    DisableImage();
                    break;

                    case "Scissors":
                    t.text = "You win!";
                    count=count+1;
                    player.sprite = Scissors;
                    ChangeToTrophySprite();
                    break;
                }
                //Debug.Log(count);
                Score.SetText("Score : "+count.ToString());
                i.sprite = Paper;
                break;

            case "Scissors":
                switch(mypref)
                {
                    case "Rock":
                    t.text = "You win!";
                    player.sprite = Rock;
                    count=count+1;
                    ChangeToTrophySprite();
                    break;

                    case "Paper":
                    t.text = "You lose!";
                    player.sprite = Paper;
                    ChangeToLosingSprite();
                    break;

                    case "Scissors":
                    t.text = "It's a Draw!";
                    player.sprite = Scissors;
                    DisableImage();
                    break;
                }
                //Debug.Log(count);
                Score.SetText("Score : "+count.ToString());
                i.sprite = Scissors;
                break;
        }
    }

    public void restart()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    // Call this function when you win
    public void ChangeToTrophySprite()
    {
        if (Image1 != null && trophySprite != null)
        {
            Image1.gameObject.SetActive(true);
            Image2.gameObject.SetActive(true);
            Image1.sprite = trophySprite;
            Image2.sprite = trophySprite;
        }
    }

    // Call this function when you lose
    public void ChangeToLosingSprite()
    {
        if (Image2 != null && losingSprite != null)
        {
            Image1.gameObject.SetActive(true);
            Image2.gameObject.SetActive(true);
            Image2.sprite = losingSprite;
            Image1.sprite = losingSprite;
        }
    }

     // Call this function when it's a draw
    public void DisableImage()
    {
         Image1.gameObject.SetActive(false);
         Image2.gameObject.SetActive(false);
    }  


}
