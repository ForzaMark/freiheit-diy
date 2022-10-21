using Assets.StateManagement;

namespace Assets.Scripts
{
    public class EnvironmentManager
    {
        private Environment Environment;

        public EnvironmentManager(Environment environment)
        {
            Environment = environment;
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

    }

}
