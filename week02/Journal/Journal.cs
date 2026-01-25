using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>(); 

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {  
          outputFile.WriteLine("\"Date\",\"Prompt\",\"Entry\"");

          foreach (Entry entry in _entries)
          {
            
            string date = entry._date.Replace("\"", "\"\"");
            string prompt = entry._promptText.Replace("\"", "\"\"");
            string text = entry._entryText.Replace("\"", "\"\"");

            outputFile.WriteLine($"\"{date}\",\"{prompt}\",\"{text}\"");
          }

        }
        
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

   
       for (int i = 1; i < lines.Length; i++)
      {
        string line = lines[i];
        
        string[] parts = line.Split("\",\"");

        string date = parts[0].TrimStart('"').TrimEnd('"');
        string prompt = parts[1].TrimStart('"').TrimEnd('"');
        string text = parts[2].TrimStart('"').TrimEnd('"');

        Entry entry = new Entry();
        entry._date = date;
        entry._promptText = prompt;
        entry._entryText = text;

        _entries.Add(entry);
       }
        
        
    }
}
    