using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyStateMachine : MonoBehaviour
{
    [SerializeField] private State _firstState;

    private Player _target;
    private State _currentState;

    public State Current => _currentState;

    private void Start()
    {
        _target = GetComponent<Enemy>().Target;
        Reset(_firstState);
    }

    private void Update()
    {
        if (_currentState == null)
        {
            return;
        }

        var nextState = _currentState.GetNextState();

        if(nextState != null)
        {
            Transit(nextState);
        }
    }

    private void Reset(State startState)
    {
        _currentState = startState;

        if(_currentState != null)
        {
            _currentState.Enter(_target);
        }
    }

    private void Transit(State state)
    {
        if(_currentState != null)
        {
            _currentState.Exit();
        }

        _currentState = state;

        if(_currentState != null)
        {
            _currentState.Enter(_target);
        }
    }
}
