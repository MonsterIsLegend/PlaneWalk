using UnityEngine;
using UnityEngine.SceneManagement;

public class BoeningButtonHandler : MonoBehaviour
{
    public void StartBoeningCockpitTour()
    {
        SceneManager.LoadScene("Boening737");
    }
}