using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {


        static Final_ProductEntities db;
        static StudentRepo()
        {
            db = new Final_ProductEntities();   

        }

    public static List<Student> Get()
        {




            return db.Students.ToList();

        }

      public static  Student Get(int id)
        {


            return db.Students.FirstOrDefault(e => e.Id == id);
        }

        public static void  Edit (Student S)
        {

            var ds = db.Students.FirstOrDefault(p=> p.Id == S.Id);
            db.Entry(ds).CurrentValues.SetValues(S);
            db.SaveChanges();

        }
        public static  void Delete (int id)
        {

            var dd = db.Students.FirstOrDefault(d => d.Id == id);
            db.Students.Remove(dd);
            db.SaveChanges();

        }

        public static void Add(Student S)
        {

            db.Students.Add(S);
            db.SaveChanges();


        }
    }
}
