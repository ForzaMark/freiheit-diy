using System.Collections;
using UnityEngine;

namespace Assets.StateManagement
{
    class FinishGameControlExplanation : State
    {
        public FinishGameControlExplanation(GameSystem gameSystem) : base(gameSystem, StateName.FinishGameControlExplanation) { }

        public override IEnumerator Execute()
        {
            yield return GameSystem.AudioManager.PlayClipSync(Scripts.AudioClipNames.FinishControlsExplanationAudioClip);
            GameSystem.ControlsTestObjectCube.SetActive(false);

            GameSystem.EnvironmentManager.EnablePlayerMovement();
            EnablePlayerTableColliderArea();

            GameSystem.SetState(new WalkToTable(GameSystem));
        }

        public static void EnablePlayerMovement(CharacterController characterController, ContinuousMovement continuousMovement) 
        {
            characterController.enabled = true;
            continuousMovement.enabled = true;
        }

        private void EnablePlayerTableColliderArea()
        {
            GameSystem.PlayerTablePositionColliderArea.SetActive(true);
        }
    }
}
