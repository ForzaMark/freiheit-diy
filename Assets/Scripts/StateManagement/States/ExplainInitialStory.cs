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
            yield return new WaitForSeconds(2f);
            yield return GameSystem.AudioManager.PlayClipAsync(AudioClipNames.InitialStoryAudioClip);
            GameSystem.SetState(new ExplainGameControls(GameSystem));
        }
    }
}
