using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{
    public void StartCockpitTour()
    {
        SceneManager.LoadScene("ArScene");
    }
}