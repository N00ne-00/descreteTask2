using System;

namespace project_2
{
    class Program
    {
        public static int find_perfectnumbers(int input) //فتحت داله جديده وعرفتها ب اي اسم 
        {
            int sum = 0;                         // عرفت متغير الجمع واديله قيمه ابتدائيه صفر
            for (int i = 1; i < input; i++)     //اعمل تكرار لكل الارقام اللي دخلت علشان اعمل شرط واعرف هل الرقم دا بيساوي مجموع قواسمه الموجبه ولا لا
            {
                if (input % i == 0) // شرط عشان اتاكد ان ناتج القسمه ب صفر لو اه ساعتها اجمع الرقم علي متغير الجمع 
                {
                    sum = sum + i;
                }
            }
            return sum; //اخليه يرجع تاني للداله وينفذها

        }



        static void Main(string[] args) // دي الداله الاصليه 
        {


            Console.Write("please enter the first number : "); // اسمح للمستخدم انه يدخل رقمين علشان احدد المجال بتاعي
            int firstnum = int.Parse(Console.ReadLine());

            Console.Write("please enter the second number : ");
            int secondnum = int.Parse(Console.ReadLine());

            for (int input = firstnum; input < secondnum; input++) //اعمل تكرار واعرف متغير واخليه يكون هو المجال كله ودا عن طريق اني اساويه بالرقم الاول واخليه اقل من الرقم التاني
            {
                int result = find_perfectnumbers(input); // اعرف متغير بالناتج واقوم بوضعه في الداله الاولي لكي اتاكد هل انطبقت عليه الداله لو اه يبقي عدد مثالي
                if (input == result) // اعمل شرط اتاكد ان الرقم دا موجود في الداله الاولي
                {
                    Console.WriteLine(input + " is perfect number"); // لو الرقم موجود وبيساويه هيكون رقم مثالي اعطي امر بالطباعه ويكون البرنامج جاهز

                }
                       // thank you :)
                       //Mariam ramadan

            }


























        }
    }
}
