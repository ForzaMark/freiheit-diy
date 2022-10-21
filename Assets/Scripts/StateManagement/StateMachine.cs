using UnityEngine;

namespace Assets.StateManagement
{

    public abstract class StateMachine : MonoBehaviour
    {
        protected State State;

        public void SetState(State state)
        {
            if (State?.StateName != state?.StateName)
            {
                DisposeOldState();
                SetNewState(state);
            }
        }

        private void DisposeOldState()
        {
            State?.Dispose();
        }

        private void SetNewState(State newState)
        {
            State = newState;
            StartCoroutine(newState.Execute());
        }
    }
}

