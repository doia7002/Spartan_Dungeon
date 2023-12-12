using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    
    public GameObject OptionPage;

    
    public void OnClickNewStart()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void OnClickLoadStart() 
    {
        SceneManager.LoadScene("MainScene");
    }
    public void OnClickOption()
    {
        OptionPage.SetActive(true);
    }
    public void OnClickOptionExit()
    {
        OptionPage.SetActive(false);
    }
    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
