using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonHandler : MonoBehaviour
{
    public void BackToStartScreen()
    {
        SceneManager.LoadScene("StartScene");
    }
}