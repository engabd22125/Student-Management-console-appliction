student_mangerr sm=new student_mangerr();

while (true)
{
    Console.WriteLine("Menu:\r\n1. Add Student\r\n2. Add Grade\r\n3. Show Student\r\n4. Show Highest Average\r\n5. Exit");
    Console.WriteLine("enter your number");
    int number=int.Parse(Console.ReadLine());
    switch (number)
    {
        case 1: sm.add_student();break;
        case 2:sm.Add_Grade();break;
        case 3: sm.Display_Student();break;
        case 4:sm.hight_average();break;
        case 5: return;



    }
    



}
class student_mangerr
{
    public Dictionary<String, List<int>> student = new Dictionary<string, List<int>>();
    string name;



    public void add_student()
    {
        Console.WriteLine("enter the name's");
        this.name = Console.ReadLine().ToLower();
        student[name] = new List<int>();


    }

    public void Add_Grade()
    {
        Console.WriteLine("enter the names");
        string name_id = Console.ReadLine().ToLower();

        foreach (var s in this.student)
        {
            if (student.ContainsKey(name_id))
            {
                Console.WriteLine("enter the number of subject");
                int sub=int.Parse(Console.ReadLine());
                for (int i = 0; i < sub; i++)
                {
                    Console.WriteLine($"mark{i+1}");
                    int mark=int.Parse(Console.ReadLine());
                    this.student[name_id].Add(mark);

                }

                break;
            }




        }




    }




  public void Display_Student()
    {
        foreach (var s in this.student)
        {
            Console.WriteLine($"{s.Key}=> {string.Join(",", s.Value)}");
        }
    }



    public void hight_average()
    {
        Dictionary<string,double> average = new Dictionary<string,double>();
        double average_o = 0;
        int total = 0;

        foreach (var s in this.student)
        {
            string name=s.Key; //add the  Dictionary 
           
            for (int i = 0; i < s.Value.Count; i++)
            {
             total += s.Value[i];
               

                if (i+1 == s.Value.Count)
                {
                    
                    average_o +=total/s.Value.Count;
                 average[name] = average_o;
                    total = 0;
                    average_o = 0;

                }
                


            }



        }



        foreach (var s in average) Console.WriteLine($"{s.Key} => {s.Value}");

        string name_max = average.Keys.First();
        double average_max = average.Values.First();
     
        foreach (var s in average)
        {
            if (s.Value > average_max)
            {
                name_max = s.Key;
                average_max=s.Value;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"the highter student : {name_max}\n is average : {average_max} ");


    }


}
