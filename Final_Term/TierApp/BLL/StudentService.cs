using BLL.BusEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class StudentService
    {
        ///application layer tekhe jokon request asbe tokon ei layer a jabe 
        ///ei khane kiso method thakte pare 
        ///Student service ar modde kiso method thakbe jeta define korbe ami ki pathabo 

        public static  List<StudentModel> Get()
        {
            var config = new MapperConfiguration(c => 
            {  
                
                c.CreateMap<Student, StudentModel>();
                c.CreateMap<Department, DepartmentModel>();

            });


            var mapper = new Mapper(config);
            var data = mapper.Map<List<StudentModel>>(StudentRepo.Get());


            return data;
        }


        public static List<String> GetName()
        {


            var data = StudentRepo.Get().Select(e=>e.Name).ToList();
            return data;

        }



        public static void Add(StudentModel S)
        {


            var config = new MapperConfiguration(c =>
            {

                c.CreateMap<StudentModel, Student>();
              
            });


            var mapper = new Mapper(config);
            var data = mapper.Map<Student>(StudentRepo.Get());

        }
    }
}
