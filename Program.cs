// See https://aka.ms/new-console-template for more information
List<string> names = new List<string> { "John Doe", "John Mills", "John Maelo", "Peter Parker" };

List<string> FilterNames(List<string> names) 
{
    names = names.OrderBy(x => x).ToList();
    names.Insert(0, "™ ™");
    names.Add("™ ™");
    for (int i = 1; i < names.Count - 1; i++)
    {
        names[i] = names[i].Split(' ')[0] == names[i + 1].Split(' ')[0] || names[i].Split(' ')[0] == names[i - 1].Split(' ')[0]
            ? names[i].Split(' ')[1][0] == names[i + 1].Split(' ')[1][0] || names[i].Split(' ')[1][0] == names[i - 1].Split(' ')[1][0]
            ? names[i] : names[i].Split(' ')[0] + " " + names[i].Split(' ')[1][0] : names[i].Split(' ')[0];
    }
    names.RemoveAt(0);
    names.RemoveAt(names.Count - 1);

    return names;
}

var result = FilterNames(names);
var breakpoint = 1;