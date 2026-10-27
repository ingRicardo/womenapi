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


            Recursion.F(3, sb);
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

            int[] accessarray = ArrayTuto.accessvalue();

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
            int[] retrunarr = ArrayTuto.ReturnArray();
            for (int i = 0; i < retrunarr.Length; i++)
                list.Add(retrunarr[i]);

            //multiarrays
            list.Add("Multidimensional Array ->");
            int[,] multiarray1 = MultiArrays.declareMultiarray();
            // int[,] arr = { { 1, 2 }, { 3, 4 } };

            List<int> row = new List<int>();
            // Iterating the Elements of Array
            for (int i = 0; i < multiarray1.GetLength(0); i++)
            {
                for (int j = 0; j < multiarray1.GetLength(1); j++)
                {
                    //Console.Write(multiarray1[i, j] + " ");
                    row.Add(multiarray1[i, j]);
                }
                list.Add(row);
                row = new List<int>();
            }



            return Ok(list);
        }




        //Two-Dimensional Array with User input
        [HttpPost("process-array-user-input")]
        public ActionResult<List<object>> ProcessArray([FromBody] int[][] inputMatrix)
        {
            List<object> list = new List<object>();

            // 1. Validate that the input matches the expected 2x3 dimensions
            if (inputMatrix == null || inputMatrix.Length != 2 ||
                inputMatrix.Any(row => row == null || row.Length != 3))
            {
                return BadRequest("Invalid input. Please provide a 2x3 matrix.");
            }

            // 2. Map the jagged array into a multi-dimensional 2D array
            int[,] arr = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = inputMatrix[i][j];
                }
            }

            // 3. Generate the formatted output string representation
            var formattedRows = new List<string>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var rowValues = new List<string>();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    rowValues.Add(arr[i, j].ToString());
                }
                formattedRows.Add(string.Join(" ", rowValues));
            }

            // FIX: Convert the 2D array (int[,]) into a jagged array (int[][]) for JSON serialization
            int[][] jaggedMatrix = new int[2][]; // or int[2][]
            int[][] serializableMatrix = new int[arr.GetLength(0)][];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                serializableMatrix[i] = new int[arr.GetLength(1)];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    serializableMatrix[i][j] = arr[i, j];
                }
            }

            // 4. Return the result as a JSON response
            list.Add(new
            {
                Message = "Elements of Array processed successfully:",
                Matrix = serializableMatrix, // Use the jagged array here instead of 'arr'
                FormattedOutput = formattedRows
            });

            return Ok(list);
        }


        // Three-Dimensional Array with User input (e.g., 2x3x4 dimensions)
       // using an example dimension of 2x3x4: 2 slices, 3 rows per slice, and 4 columns per row).
        //This version maintains the jagged array structure(int[][][]) to ensure full compatibility with System.Text.Json

        [HttpPost("process-3d-array-user-input")]
        public ActionResult<List<object>> Process3DArray([FromBody] int[][][] inputMatrix)
        {
            List<object> list = new List<object>();

            // 1. Validate that the input matches the expected 2x3x4 dimensions
            if (inputMatrix == null || inputMatrix.Length != 2 ||
                inputMatrix.Any(slice => slice == null || slice.Length != 3 ||
                slice.Any(row => row == null || row.Length != 4)))
            {
                return BadRequest("Invalid input. Please provide a 2x3x4 three-dimensional array.");
            }

            // 2. Map and build a serializable 3D jagged array (int[][][])
            // System.Text.Json does not support true multi-dimensional arrays like int[,,]
            int[][][] serializableMatrix = new int[2][][];
            for (int i = 0; i < 2; i++)
            {
                serializableMatrix[i] = new int[3][];
                for (int j = 0; j < 3; j++)
                {
                    serializableMatrix[i][j] = new int[4];
                    for (int k = 0; k < 4; k++)
                    {
                        serializableMatrix[i][j][k] = inputMatrix[i][j][k];
                    }
                }
            }

            // 3. Return the result as a JSON response
            list.Add(new
            {
                Message = "3D Array processed successfully:",
                Matrix = serializableMatrix,

            });

            return Ok(list);
        }
        /*
                [
          [
            [1, 2, 3, 4],
            [5, 6, 7, 8],
            [9, 10, 11, 12]
          ],
          [
            [13, 14, 15, 16],
            [17, 18, 19, 20],
            [21, 22, 23, 24]
          ]
        ]
        */
        [HttpGet("jaggedarray")]
        public ActionResult<List<object>> Jaggedarray()
        {
            List<object> list = new List<object>();

            list.Add(ArrayTuto.jaggedAarrDecla());
 
            list.Add(ArrayTuto.modifyarray());

            return Ok(list);

        }


        [HttpGet("arrayclass")]
        public ActionResult<List<object>> ArrayClass()
        {
            List<object> list = new List<object>();
            list.Add(ArrayTuto.classArray());
            return Ok(list);
        }

        [HttpGet("sortarray")]
        public ActionResult<List<object>> SortArray()
        {
            List<object> list = new List<object>();
            list.Add(ArrayTuto.sortArray());
            return Ok(list);
        }


        [HttpGet("stringtuto")]
        public ActionResult<List<object>> StringTuto()
        {
            List<object> list = new List<object>();
            list.Add( StringTutorial.stringbasictuto());
            return Ok(list);
        }

        [HttpGet("stringclasstuto")]
        public ActionResult<List<object>> StringClassTuto()
        {
            List<object> list = new List<object>();
            list.Add(StringTutorial.stringclasstuto());
            return Ok(list);
        }


        [HttpGet("classobjecttuto")]
        public ActionResult<List<object>> ClassObjectTuto()
        {
            List<object> list = new List<object>();
            list.Add(StringTutorial.classobjecttuto());
            return Ok(list);
        }

        [HttpGet("methodstuto")]
        public ActionResult<List<object>> MethodsTutomethod()
        {
            List<object> list = new List<object>();
            list.Add(StringTutorial.methodstuto());
            return Ok(list);
        }


    }
}
