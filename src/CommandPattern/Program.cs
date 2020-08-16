using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    class Program
    {
        /*
         * Trong ví dụ này, chúng ta sẽ thử áp dụng pattern Command vào bài toán order món ăn tại một nhà hàng. 
         * - Đầu tiên, khách hàng (customer) sẽ order món ăn. 
         * - Với từng món ăn (steak hoặc pizza) thì người phục vụ (waiter) sẽ chuyển order cho đầu bếp (chef) chuyên chế biến món đó. 
         * Với bài toán này, chúng ta có thể thấy:
            Order sẽ đóng vai trò Command.
            Steak và Pizza chính là các Concrete Command.
            Steak Chef và Pizza Chef đóng vai trò Receiver.
            Customer đóng vai trò Client.
            Waiter sẽ là cầu nối giữa Customer và Chef: Invoker.
         */

        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            Customer customer = new Customer(waiter);
            customer.Request("pizza");
            customer.Request("steak");

            Console.Read();
        }
    }
}
