using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.StateManagement
{
    class FinishGameControlExplanation : State
    {
        public FinishGameControlExplanation(GameSystem gameSystem) : base(gameSystem, StateName.FinishGameControlExplanation) { }

        public override IEnumerator Execute()
        {
            GameSystem.AudioManager.PlayClipSync(Scripts.AudioClipNames.FinishControlsExplanationAudioClip);
            yield return new WaitForSeconds(2f);

            GameSystem.ControlsTestObjectCube.SetActive(false);

            EnablePlayerMovement();
            EnablePlayerTableColliderArea();

            GameSystem.SetState(new WalkToTable(GameSystem));
        }

        private void EnablePlayerMovement() {
            GameSystem.XROrigin.GetComponent<CharacterController>().enabled = true;
            GameSystem.XROrigin.GetComponent<ContinuousMovement>().enabled = true;
        }

        private void EnablePlayerTableColliderArea()
        {
            GameSystem.PlayerTablePositionColliderArea.SetActive(true);
        }
    }
}
