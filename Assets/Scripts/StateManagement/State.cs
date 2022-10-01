using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.StateManagement
{
    public abstract class State
    {

        protected GameSystem GameSystem;

        public State(GameSystem gameSystem)
        {
            GameSystem = gameSystem;
        }

        public virtual IEnumerator Execute()
        {
            yield break;
        }
    }
}

