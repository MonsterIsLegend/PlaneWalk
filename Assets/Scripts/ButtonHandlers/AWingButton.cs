using UnityEngine;
using UnityEngine.SceneManagement;

public class AWingButton : MonoBehaviour
{
    public void StartAWingCockpitTour()
    {
        SceneManager.LoadScene("AWing");
    }
}