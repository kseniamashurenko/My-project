using UnityEngine;

public class PlayerMoveCont : MonoBehaviour
{
    private Vector2 _moveInput;
    private bool _shiftInput;
    private PlayerAnim _playerAnim;
    [Header("Move Input")]
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _walkingSpeed;
    [SerializeField] private float _runningSpeed;
    private float _currentSpeed;

    #region GetInput
    public void GetMoveInput(Vector2 input)
    {
        _moveInput= input;
    }
    public void Initialize(PlayerAnim a)
    {
        _playerAnim = a;
    }
    public void GetShiftInput(bool isPresed)
    {

    }
    public void GetSpaceInput()
    {

    }
    #endregion

    private void Move()
    {

    }
    private void Update()
    {
        Move();
        UpdateAnim();
    }
    private void UpdateAnim()
    {

    }
}
