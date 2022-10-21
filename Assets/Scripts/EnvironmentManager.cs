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
        private readonly Action<GameObject> MovePlayerByTeleportation;
        public EnvironmentManager(
            GameEnvironment environment, 
            GameObject xrDeviceSimulator,
            GameObject xrOrigin,
            Action<CharacterController, ContinuousMovement> enablePlayerMovementCallback,
            Action<GameObject> movePlayerByTeleportation)
        {
            Environment = environment;
            XrDeviceSimulator = xrDeviceSimulator;
            CharacterController = xrOrigin.GetComponent<CharacterController>();
            ContinuousMovement = xrOrigin.GetComponent<ContinuousMovement>();
            EnablePlayerMovementCallback = enablePlayerMovementCallback;
            XrOrigin = xrOrigin;
            MovePlayerByTeleportation = movePlayerByTeleportation;

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

        public void ProvideEnablePlayerMovementImplementation()
        {
            if (Environment == GameEnvironment.LocalDevelopmentWithVRHeadset || Environment == GameEnvironment.Production)
            {
                EnablePlayerMovementCallback(CharacterController, ContinuousMovement);
            }
        }

        public void ProvideTeleportationImplementation()
        {
            if (Environment == GameEnvironment.LocalDevelopmentWithMockHeadset)
            {
                MovePlayerByTeleportation(XrOrigin);
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
