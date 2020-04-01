using System;

namespace volumeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //This program is meant to find the volume of 5 different solid shapesor containers
        //By using the standard formulas for each of them
            
            string[] shapes = new string[5]{"cylinder","cone","sphere","cuboid","cube"};

            decimal pie = 3.14m;
            decimal radius = 0;
            decimal height = 0;
            decimal length = 0;
            decimal width = 0;
            decimal volume = 0;
            decimal oneThird = 0.33m;
            decimal fourThird = 1.33m;

            pie = decimal.Parse(Console.ReadLine());
            oneThird = decimal.Parse(Console.ReadLine());
            fourThird = decimal.Parse(Console.ReadLine());

            
            
            Console.WriteLine("what is the shape of your container: "); 

            // volume of cylinder = pie(3.14) * radius * radius * height
            if(shapes[0] == "cylinder")
            {
            Console.WriteLine("what is the radius of the cylinder: ");
            radius = decimal.Parse(Console.ReadLine());

            Console.WriteLine("what is the height of the cylinder: ");
            height = decimal.Parse(Console.ReadLine());
                
            volume = pie * radius * radius * height;
            Console.WriteLine("The volume of the cylinder is: " + volume );
               
            }


            //volume of cone = 1/3 * pie(3.14) * radius * radius * height

            else if(shapes[1] == "cone")
            {
            Console.WriteLine("what is the radius of the cone: ");
            radius = decimal.Parse(Console.ReadLine());

            Console.WriteLine("what is the height of the cylinder: ");
            height = decimal.Parse(Console.ReadLine());
                
            volume = oneThird * pie * radius * radius * height;
            Console.WriteLine("The volume of the cone is: " + volume );
            }


            //volume of sphere = 4/3 * pie(3.14) * radius * radius * radius
            
            else if(shapes[2] == "sphere")
            {
            Console.WriteLine("what is the radius of the sphere: ");
            radius = decimal.Parse(Console.ReadLine());
                
            volume = fourThird * pie * radius * radius * radius;
            Console.WriteLine("The volume of the sphere is: " + volume );
                
            }

//volume Of cuboid = length * width * height
            else if(shapes[3] == "cuboid")
            {
            Console.WriteLine("what is the length of the cuboid: ");
            length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("what is the width of the cuboid: ");
            width = decimal.Parse(Console.ReadLine());
                
            volume = length * width * height;
            Console.WriteLine("The volume of the cuboid is: " + volume );
               
            }


//volume of cube = length * lenght * length
            else if(shapes[4] == "cube")
            {
            Console.WriteLine("what is the radius of the cylinder: ");
            radius = decimal.Parse(Console.ReadLine());

            Console.WriteLine("what is the height of the cylinder: ");
            height = decimal.Parse(Console.ReadLine());
                
            volume = length * length * length;
            Console.WriteLine("The volume of the cube is: " + volume );
               
            }

            

                
                

            
            
        }
    }
}
