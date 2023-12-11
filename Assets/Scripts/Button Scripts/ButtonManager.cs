using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private bool state;
    public GameObject OptionPage;

    
    public void NewStart()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void LoadStart() 
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Option()
    {
        OptionPage.SetActive(true);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    private void Awake()
    {
        state = false;
    }

}
