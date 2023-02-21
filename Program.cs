using System;
using System.Collections;
public class PairingParenthesis
{

    public static void Main(string[] args)
    {
        List<string> inputList = new List<string>();
        for (int i = 1; i <= 10; i++)
        {
            var input = Console.ReadLine();
            inputList.Add(input);
        }
        FindClosingPair(inputList);
    }
    static void FindClosingPair(List<string> inputList)
    {        
        for (int inputcount = 0; inputcount<inputList.Count; inputcount++)
        {
            var input = inputList[inputcount];
            List<string> splitinput = input.Split(' ').ToList();
            int index = int.Parse(splitinput[1]) - 1; 
            var expression = splitinput[2];
            if(checkValidParathesis(expression) && expression[index] == '(')
            { 
            Stack stIndex = new Stack();
                for (int i = index; i < expression.Length; i++)
                {
                    switch (expression[i])
                    {

                        case '(':
                            stIndex.Push((int)expression[i]);
                            break;
                        case ')':
                            stIndex.Pop();
                            break;

                        default: Console.Write("#" + (inputcount + 1) + " 0" + "\n"); break;
                    }
                    if (stIndex.Count == 0)
                    {
                        Console.Write("#" + (inputcount + 1) + " " + (i + 1) + "\n");
                        break;
                    }                   
                }
            }
            else
            {
                Console.Write("#" + (inputcount + 1) + " 0" + "\n");               
            }
        }
        
    }

    static bool checkValidParathesis(string str)
    {

        int count = 0;

        if (str.Length <= 1)
            return false;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Equals('('))
                count++;
            else if (str[i].Equals(')'))
            {
                count--;
                if (count < 0)
                    return false;
            }
        }

        return (count == 0);
    }
  
    }
