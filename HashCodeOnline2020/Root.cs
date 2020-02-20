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
