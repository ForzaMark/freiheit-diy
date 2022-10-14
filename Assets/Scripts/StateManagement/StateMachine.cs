using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.StateManagement
{

    public abstract class StateMachine : MonoBehaviour
    {
        protected State State;

        public void SetState(State state)
        {
            if (State == null || State.StateName != state.StateName)
            {
                State = state;
                StartCoroutine(state.Execute());
            }
        }
    }
}

