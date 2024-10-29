
Console.WriteLine("** Davetliler **");
List<string> list = new List<string>();//Creating generic list

list.Add("Bulent Ersoy");//Adding element to list
list.Add("Ajda Pekkan");
list.Add("Ebru Gundes");
list.Add("Hadise");
list.Add("Hande Yener");
list.Add("Tarkan");
list.Add("Funda Arar");
list.Add("Demet Akalin");

foreach (string item in list)//Writing the elements of the list
{
    Console.WriteLine(item);
}

Console.ReadKey();