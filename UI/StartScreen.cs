using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private int gamePlayScene;
    public void StartButton() => SceneManager.LoadScene(gamePlayScene);
}
