using Assets.StateManagement;
using UnityEngine;
using System;

namespace Assets.Scripts
{
    public class EnvironmentManager
    {
        private readonly GameEnvironment Environment;
        
        private readonly GameObject XrDeviceSimulator;

        private readonly CharacterController CharacterController;
        private readonly ContinuousMovement ContinuousMovement;
        private readonly Action<CharacterController, ContinuousMovement> EnablePlayerMovementCallback;

        private readonly GameObject XrOrigin;
        private readonly Action<GameObject> MovePlayerByTeleportationCallback;
        public EnvironmentManager(
            GameEnvironment environment, 
            GameObject xrDeviceSimulator,
            GameObject xrOrigin,
            Action<CharacterController, ContinuousMovement> enablePlayerMovementCallback,
            Action<GameObject> movePlayerByTeleportationCallback)
        {
            Environment = environment;
            XrDeviceSimulator = xrDeviceSimulator;
            CharacterController = xrOrigin.GetComponent<CharacterController>();
            ContinuousMovement = xrOrigin.GetComponent<ContinuousMovement>();
            EnablePlayerMovementCallback = enablePlayerMovementCallback;
            XrOrigin = xrOrigin;
            MovePlayerByTeleportationCallback = movePlayerByTeleportationCallback;

            ActivateDeviceSimulator();
        }


        public float GetInitialStorySpeed()
        {
            if (Environment == GameEnvironment.Production)
            {
                return 1;
            } else
            {
                return 10;
            }
        }

        public void EnablePlayerMovement()
        {
            if (Environment == GameEnvironment.LocalDevelopmentWithVRHeadset || Environment == GameEnvironment.Production)
            {
                EnablePlayerMovementCallback(CharacterController, ContinuousMovement);
            }
        }

        public void MovePlayerByTeleportation()
        {
            if (Environment == GameEnvironment.LocalDevelopmentWithMockHeadset)
            {
                MovePlayerByTeleportationCallback(XrOrigin);
            }
        }

        private void ActivateDeviceSimulator()
        {
            if (Environment == GameEnvironment.LocalDevelopmentWithMockHeadset)
            {
                XrDeviceSimulator.SetActive(true);
            } else
            {
                XrDeviceSimulator.SetActive(false);
            }
        }

    }

}
