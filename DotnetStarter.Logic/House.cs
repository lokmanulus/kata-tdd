namespace DotnetStarter.Logic
{
    public class House
    {
        public bool[,] lights;


        public House()
        {
            lights = new bool[1000, 1000];

            InitializeLights();
        }

        private void InitializeLights()
        {
            for (int i = 0; i < lights.GetLength(0); i++)
            {
                for (int j = 0; j < lights.GetLength(1); j++)
                {
                    lights[i, j] = false;
                }
            }
        }

        public void TurnOn(int[] coord1, int[] coord2) { 
            
        }

    }
}