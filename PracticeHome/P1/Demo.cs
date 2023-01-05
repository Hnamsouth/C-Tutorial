using CSharp.Assignment.ASM1;



namespace CSharp.PracticeHome.P1
{
    class Test : Fraction
    {
        //sealed. sẽ ngăn method print ko thể overide được nữa
        public sealed override void print()
        {
        }
        static void Main(string[] args)
        {
            // neu lop duoc ke thua thi tat ca cac thuoc tinh deu duoc ke thua.doi voi thuoc tinh co private thi ko the truy cap truc tiep (co the dung getter va setter)
            Test t = new();
            
            Fraction f = new();
            int a=6; int b=7;
            int sum;
            { 
                sum = a * b;
                //Console.WriteLine(sum);
                sum = a + b;
            }
            //Console.WriteLine(sum);

            // try - catch
            try
            {

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            // loop
            int inv, returns, expenses, profit, counter = 0;
            for (inv = 100, returns = 0; returns < inv;)
            {
                Console.WriteLine("Enter inv");
                expenses=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter profit");
                profit=Convert.ToInt32(Console.ReadLine());
                inv += expenses;
                returns += profit;
                counter++;
            }
            Console.WriteLine("breack even: " + counter);
            
            List<Fraction> l = new List<Fraction>();
            
        } 
        
    }
}
