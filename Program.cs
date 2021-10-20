using System;
using System.Text;

namespace Demo_userdefine_attributes
{
    [Author_Attributes("p.hanselman")]
    class Program
    {
        [Author_Attributes("James")]
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing userdefined attributes!");
            Author_Attributes A1 = new Author_Attributes("manjith singh");
           


            Console.WriteLine("By default version of author:\t {0}",A1.Version_name);           
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Class |
                    System.AttributeTargets.Method)]
    public class Author_Attributes : System.Attribute
    {
        private string AuthorName;
        public Double Version_name;

        public Author_Attributes(string name)
        {
            this.AuthorName = name;
            Version_name = 3.0;
            Console.WriteLine("Author name is:\t{0}", name);

        }
    }
}
