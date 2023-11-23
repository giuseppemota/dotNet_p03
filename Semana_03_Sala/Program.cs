#region

using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

var tuple1 = (name:"Giuseppe",altura: 176);
var tuple2 = (name: "Maria",altura: 165);
var tuple3 = (name: "Antonio",altura: 180);

List<(string name, int altura)> list = new();

list.Add(tuple1);
list.Add(tuple2);
list.Add(tuple3);

Console.WriteLine(list.Average(x => x.altura));

#endregion