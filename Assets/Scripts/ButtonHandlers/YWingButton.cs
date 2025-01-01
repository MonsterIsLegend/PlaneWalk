using UnityEngine;
using UnityEngine.SceneManagement;

public class YWingButton : MonoBehaviour
{
    public void StartYWingCockpitTour()
    {
        SceneManager.LoadScene("YWing");
    }
}