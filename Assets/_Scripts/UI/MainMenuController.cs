using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button buttonNewGame;
    [SerializeField] private Button buttonExit;

    private void Start()
    {
        // Ïîäêëþ÷àåì êíîïêè ÷åðåç êîä
        buttonNewGame.onClick.AddListener(() => GameManager.Instance.StartGame());
        buttonExit.onClick.AddListener(() => Application.Quit());
    }
}