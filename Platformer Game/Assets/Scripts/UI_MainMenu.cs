using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    public string sceneName;

    [SerializeField] private GameObject[] uiElements;
    
    public void NewGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SwitchUI(GameObject uiToEnable)
    {
        foreach (GameObject ui in uiElements)
        {
            ui.SetActive(false);
        }

        uiToEnable.SetActive(true);
    }
}
