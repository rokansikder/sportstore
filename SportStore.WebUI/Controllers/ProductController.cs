using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using SportStore.DB.Repository;
using PagedList;
using SportStore.Domain.Entities;
using System.Data.Entity.Infrastructure;
using SportStore.DB.Abstract;

namespace SportStore.WebUI.Controllers
{

    delegate void show(int[] arr);

    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository _repo)
        {
            repository = _repo;
        }
        // GET: Product
        public ViewResult Index()
        {
            return View(repository.Products);
        }

        public FileContentResult GetImage(int productId)
        {
            Product prod = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (prod != null)
            {
                return File(prod.ImageData, prod.ImageMIMEType);
            }
            else
            {
                return null;
            }
        }

        [Route("/category")]
        [Route("home")]
        public ActionResult Home() {
            return View();
        }

      
        public ActionResult Details() {
            return View();
        }

        public ActionResult List() {
            return View();
        }

        public ActionResult List1(string searchString, string category, int? page)
        {
            LinqExample();
        //    IEnumerable<int> empty = Enumerable.Empty<int>();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        empty = empty.Concat(empty);
        //    }
        //    int[] emptyArray = empty.ToArray();


        //    IEnumerable<int> q = new int[] { 1, 2 };
        //    q = from y in q
        //        from x in new int[] { 1, 2 }
        //        select x + y;
        //    q.ToArray();


        //    IList<Student> studentList = new List<Student>() {
        //    new Student() { StudentID = 1, StudentName = "John", Age = 18, DepartmentID =1 } ,
        //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15, DepartmentID =1 } ,
        //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 , DepartmentID =2} ,
        //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 , DepartmentID =3} ,
        //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19, DepartmentID =3 }
        //};

          

        //    IList<Department> departmentList = new List<Department> {
        //        new Department { DepartmentID =1, DepartmentName="CSE"},
        //        new Department { DepartmentID = 2, DepartmentName = "JEE"},
        //        new Department { DepartmentID = 3, DepartmentName = "BIVIL"},
        //        new Department { DepartmentID = 4, DepartmentName = "BE"}
        //    };

        //    var FirstCStudent = from s in studentList
        //                        select s.StudentName.ToArray()[0];

        //    var result = from d in departmentList
        //                 select d.DepartmentName.ToArray()[0];

        //    var newResult = FirstCStudent.Intersect(result);

        //    var joinList = from d in departmentList
        //                   join s in studentList
        //                   on d.DepartmentID equals s.DepartmentID
        //                   into studentGroup
        //                   from newg in studentGroup
        //                   group newg by newg.DepartmentID into grp
        //                   orderby  grp.Key ascending select new { grp.Key, grp};


        //    foreach (var item in joinList)
        //    {
        //        Console.WriteLine(item.Key);

        //        foreach (var stud in item.grp)
        //            Console.WriteLine(stud.StudentName);
        //    }

        //    var tt = from s in studentList
        //             group s by s.DepartmentID into g
        //             where g.Any(x => x.Age > 10)
        //             select new { Students = g, Key = g.Key };
        //    //var newList = from s in studentList
        //    //              orderby s.StudentName, s.Age ascending
        //    //              select s;// studentList.OrderBy(s => s.StudentName);


        //    var newList = from s in studentList
        //                  group s by s.DepartmentID;

        //    foreach (var item in newList) {
        //        Console.WriteLine(item.Key);

        //        foreach (var s in item)
        //        {
        //            Console.WriteLine(s.StudentName);
        //        }
        //    }

        //    int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7};

        //    show sSD = (arr1) => {
        //        foreach (int item in arr1)
        //        {
        //            if (item % 2 == 1)
        //            {
        //                Console.WriteLine("Print koro");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Odd print koro");
        //            }
        //        }
                
        //    };

            //sSD(arr);

            searchString = searchString ?? "";
            category = category ?? "";
            int pageSize = 2;
            int pageNumber = (page ?? 1);
            ViewBag.CurrentFilter = searchString;
            ViewBag.Category = category;
            var products = repository.Products.Where(c=> c.Name.ToLower().Contains(searchString.ToLower())).OrderBy(o=> o.Name);

            return View(products.ToPagedList(pageNumber, pageSize));
        }

        private void LinqExample()
        {
            string delimeter = " , ";
            string[] items = new string[] { "foo", "boo", "john", "doe" };

            var s = items.Aggregate((i, j) =>i+ delimeter+j);

        }
    }

    public class Student {
        public Student() { }

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
    }


    public class Department {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}