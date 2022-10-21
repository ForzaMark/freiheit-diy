using Assets.StateManagement;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnvironmentManager
    {
        private readonly Environment Environment;
        private readonly GameObject XrDeviceSimulator;

        public EnvironmentManager(Environment environment, GameObject xrDeviceSimulator)
        {
            Environment = environment;
            XrDeviceSimulator = xrDeviceSimulator;

            ActivateDeviceSimulator();
        }


        public float GetInitialStorySpeed()
        {
            if (Environment == Environment.Production)
            {
                return 1;
            } else
            {
                return 10;
            }
        }

        private void ActivateDeviceSimulator()
        {
            if (Environment == Environment.LocalDevelopmentWithMockHeadset)
            {
                XrDeviceSimulator.SetActive(true);
            } else
            {
                XrDeviceSimulator.SetActive(false);
            }
        }

    }

}
