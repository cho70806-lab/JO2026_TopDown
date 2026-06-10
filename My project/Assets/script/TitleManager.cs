using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject helpPanel;
    

    public void GameStart()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }
    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }

    public void GameTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }


    public void ButtonLog()
    {
        Debug.Log("BUTTON CLICKED!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
