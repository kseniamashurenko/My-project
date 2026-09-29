using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    private EventBus eventBus;

    private void OnEnable()
    {
        eventBus = GameManager.Instance.eventBus;
        eventBus.OnMovePressed += OnMove;
    }
    private void OnDisable()
    {
        eventBus.OnMovePressed -= OnMove;
    }

    private void OnMove(Vector2 move)
    {
        Vector3 moveVector = new Vector3(move.x, 0f, move.y);
        transform.Translate(moveVector * Time.deltaTime, Space.World);
        Debug.Log($"{ move.x}, {move.y}");
    }
}
