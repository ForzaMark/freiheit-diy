using System.Collections;

namespace Assets.StateManagement
{
    public enum StateName
    {
        ExplainInitialStory,
        ExplainGameControl,
        GrabTestGameObject,
        FinishGameControlExplanation,
        WalkToTable,
        ConverterConstruction
    }

    public abstract class State
    {
        public StateName StateName;
        protected GameSystem GameSystem;

        public State(GameSystem gameSystem, StateName stateName)
        {
            GameSystem = gameSystem;
            StateName = stateName;
        }

        public virtual IEnumerator Execute()
        {
            yield break;
        }

        public virtual void Dispose()
        {

        }
    }
}

