using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HashCodeOnline2020
{
    class Root
    {
        string textPath = "c_medium.in";
        public void main()
        {
            string[] lines = File.ReadAllLines(textPath);

            string[] firstValues = new string[] { }; 

            if (lines.Length > 0)
            {
                firstValues = lines[0].Split(" ");
            }

            for (int i = 1; i < lines.Length; i++)
            {

            }
            //WriteResult(selectedPizzas, textPath);
        }


        /*public void WriteResult(List<Pizza> pizzas, String outputFilePath)
        {
            using (StreamWriter sw = new StreamWriter(textPath.Substring(0, textPath.Length - 2) + "out", false))
            {
                sw.WriteLine(pizzas.Count);
                foreach (var pizza in pizzas)
                {
                    sw.Write(pizza.Id + " ");
                }
            }
        }*/
    }
}
