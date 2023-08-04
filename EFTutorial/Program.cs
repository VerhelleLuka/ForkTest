using EFTutorial.DataModels;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        using Context myContext = new Context();

        var myClasses = myContext.Classes.Where(c=>c.MaxClassSize > 0).ToList();
        myClasses[0].ClassLanguage = EFTutorial.Enums.Language.German;
        //myContext.Students.Add(new Student()
        //{
        //    StudentName = "John Smith",
        //    StudentClasses = new List<Class>()
        //    {
        //        new Class()
        //        {
        //            ClassLanguage = EFTutorial.Enums.Language.French,
        //            ClassName = "History",
        //            MaxClassSize = 11
        //        },
        //                        new Class()
        //        {
        //            ClassLanguage = EFTutorial.Enums.Language.English,
        //            ClassName = "Maths",
        //            MaxClassSize = 25
        //        }
        //    }
            
        //});
        myContext.SaveChanges();
    }
}