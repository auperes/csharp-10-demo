using CSharp10Demo.Model;

var user = new User { Name = "DotNetBot" };


Console.WriteLine($"Hello {user.Name}");

// record
//var user2 = new User { Name = "DotNetBot" };
//var result = user == user2;
//Console.WriteLine($"user is equal to user2: {result}");

// anonymous types for lambdas: var, Delegate, attributes
Func<string, int> parse = (string s) => int.Parse(s);

