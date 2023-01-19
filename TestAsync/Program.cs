using TestAsync;

Console.WriteLine("00000---------------------00000");
//var result = await (new UrlLoader()).GetUrlLengthAsync();

//Console.WriteLine("Result {0}", result);

//var worker = new TimeTaskMocker();

//worker.Work(5);
//Console.WriteLine("Waiting task 5");
//worker.Work(2);
//Console.WriteLine("Waiting task 2");

//Console.ReadLine();

Humain humain = new();
var petitDejeuner = await humain.PreparerPetitDejeuner();


Console.ReadLine();






