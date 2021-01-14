using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace single_responsibility_principle
{
  public class Journal
  {
    private readonly List<string> entries = new List<string>();

    private static int count = 0;

    public int AddEntry(string text)
    {
      entries.Add($"{++count}: {text}");
      return count;
    }

    public void RemoveEntry(int index)
    {
      entries.RemoveAt(index);
    }

    public override string ToString()
    {
      return string.Join(Environment.NewLine, entries);
    }

    // breaks single responsibility principle
    public void Save(string filename, bool overwrite = false)
    {
      File.WriteAllText(filename, ToString());
    }

    public void Load(string filename)
    {

    }

    public void Load(Uri uri)
    {

    }
  }

  // handles the responsibility of persisting objects
  public class Persistence
  {
    public void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
      if (overwrite || !File.Exists(filename))
      {
        // Console.WriteLine(filename);
        // Console.WriteLine(journal);
        File.WriteAllText(filename, journal.ToString());
      }

    }
  }
  public class Program
  {
    /* Single responsibility principle specifies that any particular
    * class should have only one single reason to change
    */

    public static void Main(string[] args)
    {
      var j = new Journal();
      j.AddEntry("I cried today.");
      j.AddEntry("I ate a bug.");
      Console.WriteLine(j);

      var p = new Persistence();
      var path = Directory.GetCurrentDirectory();
      var filename = $"{path}/journal.txt";
      p.SaveToFile(j, filename);
      Process.Start(filename);
    }
  }
}
