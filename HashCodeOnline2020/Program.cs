using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HashCodeOnline2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int LibNumber;
            int booksNumber;
            int ScanDays;
            List<Book> Score = new List<Book>();
            List<Library> libs = new List<Library>();
            int count = 0;
            var Result = new List<LibResult>();

            string path = @"C:\Users\Godz_fk50\Downloads";
            string PathToFile = "e_so_many_books.txt";

            using (StreamReader sr = new StreamReader(PathToFile))
            {
                var line = sr.ReadLine();
                var Parts = line.Split(' ');
                booksNumber = int.Parse(Parts[0]);
                LibNumber = int.Parse(Parts[1]);
                ScanDays = int.Parse(Parts[2]);

                line = sr.ReadLine();
                Parts = line.Split(' ');
                for (int i = 0; i < booksNumber; i++)
                {
                    Score.Add(new Book { id =  i, Score = int.Parse(Parts[i]) });
                }

                for (int i = 0; i < LibNumber; i++)
                {
                    line = sr.ReadLine();
                    Parts = line.Split(' ');

                    var lib = new Library();
                    lib.id = count;
                    lib.BooksCount = int.Parse(Parts[0]);
                    lib.SignUp = int.Parse(Parts[1]);
                    lib.ShipCount = int.Parse(Parts[2]);
                    lib.Books = new List<Book>();

                    line = sr.ReadLine();
                    Parts = line.Split(' ');

                    for (int j = 0; j < lib.BooksCount; j++)
                    {
                        //var newBook = Score[int.Parse(Parts[j])];
                        lib.Books.Add(Score[int.Parse(Parts[j])]);
                        Score[int.Parse(Parts[j])].deleteBook += lib.removeBook;
                    }

                    libs.Add(lib);
                    count++;
                }
            }

            ////////////////////////////
            ///

            var libsAcs = libs.OrderBy(x => x.SignUp);

            
            libsAcs = libsAcs.Take((Int32)(libsAcs.Count()* 0.6)).OrderByDescending(x => x.ShipCount);
            foreach(var item in libsAcs) {
                ScanDays -= item.SignUp;
                int maxBookCount = ScanDays  * item.ShipCount;
                var libRes = new LibResult();
                libRes.Books = new List<int>();
                libRes.id = item.id;
                item.Books = item.Books.OrderByDescending(x => x.Score).ToList();

                int i = 0;
                while (maxBookCount > libRes.Books.Count && item.Books.Count != 0)
                {
                    libRes.Books.Add(item.Books[0].id);
                    item.Books[0].fireEventDeleteBook();
                }



                Result.Add(libRes);
            }

            ///////////////////////////////////////////////////
            ///

            var newResult = new List<LibResult>(Result);
            Result = new List<LibResult>();

            foreach (var item in newResult)
            {
                if (item.Books.Count() > 0)
                {
                    Result.Add(item);
                }
            }

            using (StreamWriter sw = new StreamWriter(PathToFile.Substring(0, PathToFile.Length - 3) + "out"))
            {
                sw.WriteLine(Result.Count());
                foreach (var item in Result)
                {
                    sw.Write(item.id);
                    sw.Write(' ');
                    sw.Write(item.Books.Count());
                    sw.WriteLine();
                    foreach (var b in item.Books)
                    {
                        sw.Write(b);
                        sw.Write(' ');
                    }
                    sw.WriteLine();
                }
                sw.WriteLine();
            }

            Console.WriteLine("Done!");

            Console.ReadKey();

        }
    }
}
