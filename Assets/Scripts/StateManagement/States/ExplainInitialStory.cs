using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class ExplainInitialStory : State
    {
        public ExplainInitialStory(GameSystem gameSystem): base(gameSystem, StateName.ExplainInitialStory) { }

        public override IEnumerator Execute()
        {
            yield return GameSystem.AudioManager.PlayClipSync(AudioClipNames.InitialStoryAudioClip);
            GameSystem.SetState(new ExplainGameControls(GameSystem));
        }
    }
}
