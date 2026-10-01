using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    private EventBus eventBus;
    private bool _isDead;
    [SerializeField] private PlayerAnim _playerAnim;
    [SerializeField] private PlayerMoveCont _playerMove;
    [SerializeField] private PlayerCameraCont _playerCamCont;
    [SerializeField] private PlayerShootCont _playerShoot;
    private void OnEnable()
    {
        eventBus = GameManager.Instance.eventBus;
        _playerMove.Initialize(_playerAnim);
        eventBus.OnMovePressed += OnMove;
        
    }
    private void OnDisable()
    {
        eventBus.OnMovePressed -= OnMove;
    }

    private void OnMove(Vector2 move)
    {
        if (_isDead) return;
        _playerMove.GetMoveInput(move);
        //Vector3 moveVector = new Vector3(move.x, 0f, move.y);
        //transform.Translate(moveVector * Time.deltaTime, Space.World);
    }  
    private void OnF()
    {

    }
    private void OnSpace()
    {

    }
    private void OnLook()
    {

    }
    private void OnShift()
    {

    }
    private void OnLeftMouseButton()
    {

    }
}
