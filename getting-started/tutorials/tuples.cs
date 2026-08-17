// Tuples
// Tuples are an ordered sequence of values with a fixed length. Each element of a tuple has a type and an optional name.
var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

// You can also create a new tuple that's a modified copy of the original using a `with` expression. 
var pt2 = pt with { Y = 10 };
// The tuple pt2 contains the X value of pt (6), and pt2.Y is 10. 
Console.WriteLine($"pt2 created.");
Console.WriteLine($"The point 'pt' is now at {pt}.");
Console.WriteLine($"The point 'pt2' is at {pt2}."); 

// Tuples are structural types, meaning that tuple types don't have names like string or int. A tuple type is defined by the number of members, referred to as `arity`, and the types of those members. The member names are for convenience. You can assign a tuple to a tuple with the same arity and types even if the members have different names.

var subscript = (A: 0, B: 0);
// The variable subscript has two members, both of which are integers. 
subscript = pt;
// Both subscript and pt represent instances of the same tuple type: a tuple containing two int members.
Console.WriteLine(subscript);   // Subscript displays (6,2)


// Tuples are easy to create: You declare multiple members enclosed in parentheses. All the following declarations define different tuples with different arities and member types.

var namedData = (Name: "Morning observation", Temp: 17, Wind: 4); // ARITY: 3
var person = (FirstName: "", LastName: ""); // ARITY: 2
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m); // ARITY: 4

// While tuples are easy to create, they're limited in their capabilities. 
// Tuple types don't have names, so you can't convey meaning to the set of values. 
// Tuple types can't add behavior. C# has other kinds of types you can create when your type defines behavior.

// Records
// Tuples work well when you want multiple values in the same structure. They're lightweight, and you can declare them as you use them.
// If you find that you're using the same tuple type, you can declare a record type that stores those values and provides more capabilities.
 
Point pt3 = new Point(1, 1);        // constructs a Point using the record's generated Point constructor.
var pt4 = pt3 with { Y = 10 };      // performs nondestructive mutation: it creates a new Point that's a copy of pt3, but with Y replaced by 10. pt3 itself is untouched.
Console.WriteLine($"The two points are {pt3} and {pt4}");

double slopeResult = pt4.Slope();   // Accesses the record member function, `Slope()`
Console.WriteLine($"The slope of {pt4} is {slopeResult}");

// Type declarations like `record` declarations must follow executable statements in a file-based app. 
public record Point(int X, int Y)  // declares a record named Point with two positional parameters. X and Y are readonly properties.
// You can add behavior to a record type by declaring members. 
// The members of a type are in the type declaration, between { and } characters. 
{
    // A record member can be a function/method or an attribute/data element. 
    public double Slope() => (double)Y / (double)X;
}