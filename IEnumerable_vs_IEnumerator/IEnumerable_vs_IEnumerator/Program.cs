using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_vs_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> WeekDays = new List<string>();
            WeekDays.Add("Sunday");
            WeekDays.Add("Monday");
            WeekDays.Add("Tuesday");
            WeekDays.Add("Wednesday");
            WeekDays.Add("Thursday");
            WeekDays.Add("Friday");
            WeekDays.Add("Saturday");

            Console.WriteLine("********** Print Collection with IEnumerable **********");
            IEnumerable<string> iEnum = (IEnumerable<string>)WeekDays;

            foreach (string str in iEnum)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("********** Print Collection with IEnumerator **********");
            IEnumerator<string> iEnumerat = WeekDays.GetEnumerator(); // to convert list into IEnumerator we can invoke the GetEnumerator method

            while(iEnumerat.MoveNext())
            {
                Console.WriteLine(iEnumerat.Current.ToString());
            }

            Console.ReadLine();




            List<int> myYears = new List<int>();
            myYears.Add(2001);
            myYears.Add(2002);
            myYears.Add(2003);
            myYears.Add(2004);
            myYears.Add(2005);
            myYears.Add(2006);
            myYears.Add(2007);

            IEnumerable<int> iEnum2 = (IEnumerable<int>)myYears;
            PrintFirstThreeValues(iEnum2);
            Console.ReadLine();



            IEnumerator<int> iEnumerat2 = myYears.GetEnumerator();
            PrintFirstThreeValues(iEnumerat2);
            Console.ReadLine();

        }

        static void PrintFirstThreeValues(IEnumerable<int> Obj)
        {
            foreach (int temp in Obj)
            {
                Console.WriteLine(temp.ToString());

                if(temp>2002)
                {
                    PrintLastFourValues(Obj);
                }
            }
        }

        static void PrintLastFourValues(IEnumerable<int> Obj)
        {
            foreach (int temp in Obj)
            {
                Console.WriteLine(temp.ToString());
            }
        }

        static void PrintFirstThreeValues(IEnumerator<int> Obj)
        {
            while(Obj.MoveNext())
            {
                Console.WriteLine(Obj.Current.ToString());

                if ((int)Obj.Current > 2002)
                {
                    PrintLastFourValues(Obj);
                }
            }
        }

        static void PrintLastFourValues(IEnumerator<int> Obj)
        {
            while(Obj.MoveNext())
            {
                Console.WriteLine(Obj.Current.ToString());
            }
        }














        public IEnumerator GetEnumerator()
        {
            // return IEnumerator of our Custom Type
            return (IEnumerator)this;
        }

        // IEnumerator interface contains the below three methods Reset, MoveNext, Current

        //public void Reset()
        //{
        //    //Get total number of element in a collection
        //    length = slist.Count;
        //    //Setting the pointer to just before the beginning of collection
        //    current = -1;
        //}

        //public bool MoveNext()
        //{
        //    //this will increment the counter variable
        //    //and will check whether it is exceeding the actual length of our collection
        //    return (++current < length);
        //}

        //public object Current
        //{
        //    get
        //    { //Here "slist" is the collection and "current" is the location pointer 
        //        return (slist[current]);
        //    }
        //}


    }
}
