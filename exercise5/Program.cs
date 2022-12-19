using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*Intializing the values of the variables REAR and FRONT to -1 to indicate 
           * the queue is intially empty. */
            FRONT = -1;
            REAR = -1;
        }
    }
    public void insert(int element)
    {
        // This statement checks for the overflow condition.
        if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
        {
            Console.WriteLine("\nQueue overflow\n");
            return;
        }
        /*this following statement checks whether the queue is empty. if the queue is empty
         * , then the value of the  RWAR and FRONT variables is set to 0 */
        if ((FRONT == -1))
        {
            FRONT = 0;
            REAR = 0;
        }
    }