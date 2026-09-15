using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDinicialMan : MonoBehaviour
{
    [SerializeField] private GameObject controlesHud;

    public void OnClickStartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OnClickControlesButton()
    {
        if (controlesHud == null)
        {
            Debug.LogWarning("ControlesHud não atribuído no Inspector.");
            return;
        }

        controlesHud.SetActive(true);
    }

    public void OnClickCloseControlsButton()
    {
        if (controlesHud == null)
        {
            Debug.LogWarning("ControlesHud não atribuído no Inspector.");
            return;
            }

        controlesHud.SetActive(false);
    }

    public void OnClickExitButton()
    {
               Application.Quit();
    }
}
