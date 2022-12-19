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
            else
            {
                /* if REAR is at the last position of the array, than the value of 
                 * REAR is set to 0 that corresponds to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /*If REAR is not at the last position , then its values is increamented by one*/
                    REAR = REAR + 1;
            }
            /* Once the position of REAR is determind, the element is added at its proper place. */
            queue_array[REAR] = element;
        }
        public void remove()
        {
            // checks wheather the queue is empty
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe Element deleted from queue is: " + queue_array[FRONT]
                + "\n");
            // Check if the queue has one element. 
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* If the element to be deleted is at the last position of the array, then the value 
                 * of FRONT is set to 0 i.e to the first element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    // FRONT is incremented by one if it is not the first element of array.
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            // Checks if the queue is empty
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is  empty\n");
                return;
            }
            Console.WriteLine("\nElements  is the queue are ...................\n");
            if (FRONT_position <= REAR_position)
            {
                // traverses the queue till the last element present in array 
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                // traverses the queue till the last possition og the array
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "      ");
                    FRONT_position++;
                }
                // set the FRONT position to the first element of the array 
                FRONT_position = 0;
                //traverses the array till the the last element present in the queue 
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "      ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
    }
}

