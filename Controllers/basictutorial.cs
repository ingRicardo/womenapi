using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    }
}
