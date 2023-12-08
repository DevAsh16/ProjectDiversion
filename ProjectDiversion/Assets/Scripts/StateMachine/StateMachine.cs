using UnityEngine;

namespace StateMachine
{
    public abstract class StateMachine
    {
        protected State currentState;

        protected void Update()
        {
            currentState?.OnUpdate(Time.deltaTime);
        }

        public virtual void ChangeState(State nextState)
        {
            currentState?.OnExit();
            currentState = nextState;
            currentState?.OnEnter();
        }
    }
}

