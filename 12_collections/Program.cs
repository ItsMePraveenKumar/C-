/*

01. Array
--> Fixed size.

*/
int[] arr = {1,3,2};
foreach(int element in arr)
{
    Console.Write(element + " ");
}
Console.WriteLine("\n");

/*
-------------------------------------------------------------------

02. List
--> Dynamic size.
--> Can store single type of data

*/
List<String> lst = new List<string>();
lst.Add("Hero");
lst.Add("Enemy");
lst.Add("NPC");
foreach(string element in lst)
{
    Console.Write(element + " ");
}
Console.WriteLine("\n");

/*
-------------------------------------------------------------------

03. Dictionary
--> Stores key-value pairs.

*/
Dictionary<String, int> dict = new Dictionary<string, int>();
dict["Age"] = 24;
dict["Marks"] = 80;
foreach (KeyValuePair<string, int> data in dict)
{
    Console.WriteLine($"{data.Key} : {data.Value}");
}
Console.WriteLine("\n");

/*
-------------------------------------------------------------------

04. HashSet
--> Stores unique values only.

*/
HashSet<string> items = new HashSet<string>();
items.Add("Sword");
items.Add("Bow");
items.Add("Sword");
Console.WriteLine(items.Count);
foreach(string item in items)
{
    Console.WriteLine(item + " ");
}
Console.WriteLine("\n");