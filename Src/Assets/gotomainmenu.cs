using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotomainmenu : MonoBehaviour
{
    public void GoToMainMenu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene(0);
    }
}
