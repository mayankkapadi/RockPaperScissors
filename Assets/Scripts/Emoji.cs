using UnityEngine;
using UnityEngine.UI;

public class Emoji : MonoBehaviour
{
    public Sprite trophySprite; // Drag your trophy sprite here in the Inspector
    public Sprite losingSprite; // Drag your losing sprite here in the Inspector

    public Image Image1; // Drag your Image component here in the Inspector
    public Image Image2; // Drag your Image component here in the Inspector

    // Call this function when you win
    public void ChangeToTrophySprite()
    {
        if (Image1 != null && trophySprite != null)
        {
            Image1.sprite = trophySprite;
            Image2.sprite = trophySprite;
        }
    }

    // Call this function when you lose
    public void ChangeToLosingSprite()
    {
        if (Image2 != null && losingSprite != null)
        {
            Image2.sprite = losingSprite;
            Image1.sprite = losingSprite;
        }
    }
}

