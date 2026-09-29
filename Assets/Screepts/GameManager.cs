using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState currentGameState { get; private set; } = GameState.system;
    public EventBus eventBus  { get; private set; }
    [SerializeField] private InputManager inputManager;


    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this);
        Instance = this;
        OnChangeScene(SceneList.game);
        eventBus = new EventBus();
        inputManager.Initialized(eventBus);
        OnChangeScene(SceneList.game);

    }
    private void OnChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    private void ChangeGameState(GameState state)
    {
        if (currentGameState == state) return;
        currentGameState = state;
    }

  
}
public enum GameState
{
    system = 0,
    game=1,
    mainMenu=2
}
