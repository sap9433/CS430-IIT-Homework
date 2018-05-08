using System;
using System.Collections.Generic;
using System.Text;

namespace WaterJug
{
    class JugBFS
    {

        private static List<Program> visitState = new List<Program>();
        private static Queue<Program> stateQueue = new Queue<Program>();

        public static void Main()
        {
            Program currentState = new Program(0, 0);
            stateQueue.Enqueue(currentState);

            while (stateQueue.Count != 0)
            {
                Program firstIQueue = stateQueue.Peek();

                if (firstIQueue.IsGoal)
                {

                    foreach (Program state in visitState)
                    {
                        Console.WriteLine(state.ToString());
                    }

                    return;
                }

                else
                {
                    visitState.Add(firstIQueue);

                    List<Program> children = firstIQueue.getChildren();

                    foreach (Program state in children)
                    {
                        if (!visitState.Contains(state))
                        {
                            stateQueue.Enqueue(state);
                        }
                    }

                    stateQueue.Dequeue();
                }

            }
        }
    }
}
