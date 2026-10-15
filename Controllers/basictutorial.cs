using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using WebWomen.Data;
using WebWomen.Models;
using WebWomen.Services;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using static WebWomen.Services.ReturnDelegateDemo;
namespace WebWomen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasicTutorial : ControllerBase
    {
        private readonly AppDbContext _context;

        public BasicTutorial(AppDbContext context)
        {
            _context = context;
        }

        // Mock data to simulate a database query
        private static readonly List<string> Products = new()
        {
            "Laptop", "Smartphone", "Tablet", "Smartwatch"
        };

        // GET: api/basictutorial
        //[HttpGet("all-products")]
        [HttpGet()]
        public ActionResult<IEnumerable<string>> Get()
        {
            Console.WriteLine("console logs--");
            // Returns a 200 OK status code along with the list
            return Ok(Products);
        }

        [HttpGet("keywords")]
        public ActionResult<List<CSharpKeywordModel<string>>> GetTutoJson()
        {
            List<string> valuetype = [
                "bool", "byte", "char", "decimal",
                "double", "enum", "float", "int", "long", "sbyte", "short", "struct", "uint", "ulong", "ushort"
            ];

            List<string> reference_type = [
                "public", "private", "internal", "protected", "abstrac", "const",
                "event", "extern", "new", "override", "partial", "readonly", "sealed", "static", "unsafe", "virtual", "volatile"
            ];

            List<string> statementKeywords = [
                "if", "else", "switch", "do", "for", "foreach", "in", "while", "break", "continue", "goto", "return", "throw", "try", "catch", "finally", "checked", "unchecked"
            ];
            List<string> contextualKeywords = [
                "add", "alias", "ascending", "async", "await", "by", "descending", "dynamic", "equals", "from", "get", "global", "group", "into", "join", "let", "nameof", "on", "orderby", "partial", "remove", "select", "set", "value", "var", "when", "where", "yield"
            ];


            List<CSharpKeywordModel<string>> keywordCategories = [
                new CSharpKeywordModel<string>("Value Type Keywords", valuetype),
                new CSharpKeywordModel<string>("Reference Type Keywords", reference_type),
                new CSharpKeywordModel<string>("Statement Keywords", statementKeywords),
                new CSharpKeywordModel<string>("Contextual Keywords", contextualKeywords),

            ];

            return Ok(keywordCategories);
        }

        [HttpGet("variables")]
        public ActionResult<List<int>> getVariables()
        {
            nmberstuto numb = new nmberstuto();
            numb.numbers1();
            return Ok(numb.numbers1());
        }

        [HttpGet("datatypes")]
        public ActionResult<List<Object>> getDataTypes()
        {
            DataTypesTuto dataTypes = new DataTypesTuto();
            return Ok(dataTypes.getDataTypes());
        }

        [HttpGet("typecasting")]
        public ActionResult<List<Object>> getTypeCasting()
        {
            TypeCasting casting = new TypeCasting();


            return Ok(casting.getcasting());
        }

        [HttpGet("delegates")]
        public ActionResult<Dictionary<string, int>> getDelegates()
        {
            Dictionary<string, int> delres = new Dictionary<string, int>();

            Operation op = Add;

            delres.Add("Addition", op(5, 3));
            op = Multiply;
            delres.Add("Multiplication", op(5, 3));


            return Ok(delres);
        }

        [HttpGet("entryloop")]
        public ActionResult<List<Object>> GetWhileLoop()
        {
            Entryloops entryloops = new Entryloops();

            return Ok(entryloops.EntryLoops());
        }

        [HttpGet("methodstutorial")]
        public ActionResult<List<Object>> GetMethodsTutorial()
        {
            MethodsTuto methodsTuto = new MethodsTuto();

            List<Object> list = new List<Object>();

            // Create an instance of Geeks Call the instance method directly
            list.Add(methodsTuto.DisplayMessage());

            // Call static method using class name
            int result = MethodsTuto.Square(5);

            list.Add("Square of 5 is: " + result);



            int value = 10;

            // Call method with value parameter
            list.Add(MethodsTuto.Display(value));

            // Call method with reference parameter
            list.Add(MethodsTuto.Update(ref value));

            int outputValue;

            // Call method with output parameter
            MethodsTuto.GetValues(out outputValue);
            list.Add("Output value is: " + outputValue);



            result = MethodsTuto.Sum(10, 20, 30, 40);
            list.Add(result);


            // Uses the default value of age
            list.Add(MethodsTuto.Scholar("Ankita"));
            // Provides a value for age
            list.Add(MethodsTuto.Scholar("Siya", 25));



            return Ok(list);
        }

        [HttpGet("methodoverload")]
        public ActionResult<List<Object>> GetOverload()
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            List<Object> list = new List<Object>();
            list.Add("Add(int, int): " + methodOverloading.Add(5, 10));
            list.Add("Add(int, int, int): " + methodOverloading.Add(5, 10, 15));
            list.Add("Add(double, double): " + methodOverloading.Add(5.5, 10.5));


            list.Add("StudentId(string, int): " + methodOverloading.StudentId("Sweta", 101));
            list.Add("StudentId(int, string): " + methodOverloading.StudentId(102, "riky"));

            list.Add("Show(int): " + methodOverloading.Show(250));
            list.Add("Show(string): " + methodOverloading.Show("Hello, World!"));
            list.Add("Show(byte): " + methodOverloading.Show((byte)25));
            list.Add("Show(char): " + methodOverloading.Show('A'));

            return Ok(list);
        }

        [HttpGet("recursiontuto")]
        public ActionResult<List<Object>> GetRecursion()
        {
           
            List<Object> list = new List<Object>();
            StringBuilder sb = new StringBuilder();

            Recursion.PrintHello(5, sb);
            string input = sb.ToString();
            string[] resultClean = input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in resultClean)
            {
                list.Add(item);
            }
            sb = new StringBuilder();


            Recursion.F(3,sb);
            input = sb.ToString();
            resultClean = input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in resultClean)
            {
                list.Add(item);
            }

            return Ok(list);
        }

        [HttpGet("arrays")]
        public ActionResult<List<object>> GetArr()
        {
            List<object> list = new List<object>();

            int[] arr = ArrayTuto.firstarray();
            int n = arr.Length;

            list.Add("Value Type Array -> ");
            for (int i = 0; i < n; i++)
                list.Add(arr[i]);

            list.Add(arr);

            list.Add("Reference Type Array -> ");

            string[] names = ArrayTuto.refarray();
            for (int i = 0; i < names.Length; i++)
                list.Add(names[i]);
            list.Add(names);

            int[,] multiarr = ArrayTuto.multiarray();

            list.Add("multidimensionalArray ->");

            list.Add(multiarr[0, 1]);
            list.Add(multiarr[1, 0]);


            list.Add("Jagged Array ->");

            int[][] jagarr = ArrayTuto.jaggedArray();

            List<int> li = new List<int>();
            for (int i = 0; i < jagarr.Length; i++)
            {
                foreach (int value in jagarr[i])
                {
                    li.Add(value);
                }
                list.Add(li);
                li = new List<int>();
            }

            list.Add("Accessing Value from Array ->");
            
            int [] accessarray = ArrayTuto.accessvalue();

            list.Add(accessarray);
            // Accessing the fourth element
            list.Add("Accessing the fourth element ->");
            list.Add(accessarray[3]);
            // Accessing the first element
            list.Add("Accessing the first element ->");
            list.Add(accessarray[0]);


            // Updating the first element
            
            list.Add("new array to update ->");
            int[] originalarr = ArrayTuto.modifyvalue();
            list.Add(originalarr);
            list.Add($"Updating the first element -> {originalarr[0]} -> 90");
            int[] updatearray = ArrayTuto.modifyvalue();
            updatearray[0] = 90;
            list.Add(updatearray);
            list.Add("traverse an array ->");

            // Traversing and printing the array
            for (int i = 0; i < updatearray.Length; i++)
            {
                list.Add(updatearray[i]);
            }

            list.Add("Size of array: ");
            list.Add(updatearray.Length);


            list.Add("Array of Objects ->");

            Student[] studentarr = ArrayTuto.studentarray();
            list.Add(studentarr);
            // Accessing the array elements
            for (int i = 0; i < studentarr.Length; i++)
            {
               list.Add(
                    "Element at " + i + " : { " +
                    studentarr[i].roll_no + " " +
                    studentarr[i].name + " }");
            }

            // Sum of array elements
            list.Add("New array Sum of array elements ->");
            int[] sumarr = { 3, 1, 2, 5, 4 };
            list.Add(sumarr);
            // Passing the array to the Sum method
            list.Add("Sum of array elements: ");
            list.Add(ArrayTuto.Sum(sumarr));

            list.Add("Returning a new array ->");
            int [] retrunarr = ArrayTuto.ReturnArray();
            for (int i = 0; i < retrunarr.Length; i++)
                list.Add(retrunarr[i]);

            return Ok(list);
        }

    }
}
