using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameScreen : MonoBehaviour
{
    [SerializeField] private GameObject endPopUp;
    [SerializeField] private Image looseImage;
    [SerializeField] private Image winImage;
    [SerializeField] private int gameplayScene;

    private void OnEnable()
    {
        PlayerCollisions.OnCrash += ShowLoosePopUp;
        PlayerCollisions.OnWin += ShowWinPopUp;
    }

    private void OnDisable()
    {
        PlayerCollisions.OnCrash -= ShowLoosePopUp;
        PlayerCollisions.OnWin -= ShowWinPopUp;
    }

    private void Start() => endPopUp.SetActive(false);
    private void ShowLoosePopUp()
    {
        endPopUp.SetActive(true);        
        winImage.gameObject.SetActive(false);
    }
    private void ShowWinPopUp()
    {
        endPopUp.SetActive(true);
        looseImage.gameObject.SetActive(false);
    }

    public void RestartButton() => SceneManager.LoadScene(gameplayScene);

    public void QuitButton() => Application.Quit();
}
