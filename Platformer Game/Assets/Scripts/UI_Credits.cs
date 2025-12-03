using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Credits : MonoBehaviour
{
    [SerializeField] private RectTransform rectT;
    [SerializeField] private float scrollSpeed = 200;
    [SerializeField] private float offScreenPosition = 1000;

    [SerializeField] private string mainMenuScene = "MainMenu";
    private bool creditsSkipped;

    private void Update()
    {
        rectT.anchoredPosition += Vector2.up * scrollSpeed * Time.deltaTime;

        if(rectT.anchoredPosition.y > offScreenPosition)
        {
            GoToMainMenu();
        }
    }

    public void SkipCredits()
    {
        if (creditsSkipped == false)
        {
            scrollSpeed *= 10;
            creditsSkipped = true;
        }
        else
        {
            GoToMainMenu();
        }
            
    }

    private void GoToMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
