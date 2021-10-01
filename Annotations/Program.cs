using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.FirstName = "Xyz";
            author.LastName = "abjg";
            author.PhoneNumber = "9834978189";
            author.Email = "varunlad@gmail.com";
            //use it for author
            TestAuthorModel(author);

            ////use it for Employee
            //Type type = Type.GetType("MoodAnalyser05Batch.Employee");
            //CustomAttribute.AttributeDisplay(typeof(Employee));
            Console.ReadLine();
        }
        public static void TestAuthorModel(Author author)
        {
            ValidationContext context = new ValidationContext(author, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(author, context, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Satisfied all the validations");
            }
        }

    }
}
