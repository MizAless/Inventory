using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputConnector
{
    private PlayerInput _playerInput;
    private Mover _mover;

    private bool _isMoveing = false;

    private Coroutine _moveingRoutine;

    public PlayerInputConnector(Mover mover)
    {
        _playerInput = new PlayerInput();
        _mover = mover;
    }

    public void Enable()
    {
        _playerInput.Enable();
        _playerInput.Player.Move.performed += StartMove;
        _playerInput.Player.Move.canceled += EndMove;
    }

    public void Disable()
    {
        _playerInput.Player.Move.performed -= StartMove;
        _playerInput.Player.Move.canceled -= EndMove;
        _playerInput.Disable();
    }

    private void StartMove(InputAction.CallbackContext callbackContext)
    {
        if (_moveingRoutine != null)
            return;

        _moveingRoutine = CoroutineProvider.Instance.StartCoroutine(Moveing(callbackContext));
    }

    private void EndMove(InputAction.CallbackContext callbackContext)
    {
        _isMoveing = false;

        CoroutineProvider.Instance.StopCoroutine(_moveingRoutine);
        _moveingRoutine = null;
    }

    private IEnumerator Moveing(InputAction.CallbackContext callbackContext)
    {
        _isMoveing = true;

        while (_isMoveing)
        {
            Vector2 inputVector = callbackContext.ReadValue<Vector2>();
            Vector3 direction = new Vector3(inputVector.x, 0, inputVector.y);

            _mover.Move(direction);

            yield return null;
        }
    }
}
