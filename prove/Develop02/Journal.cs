using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
public class Journal
{
    
    private List<Entry> _entries = new List<Entry>();

    //Method to add an Entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    //Method to display all Entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    //Method to save journal entries to a file
    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine($"Journal saved successfully to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
    //Method to load journal entries from a file
    public void LoadFromFile(string fileName)
    {
        try
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"The file {fileName} does not exist.");
                return;
            }
        
            _entries.Clear(); //Clear current entries
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {

                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry loadedEntry = new Entry(date, prompt, response);
                    _entries.Add(loadedEntry);
                }
                else
                {
                    Console.WriteLine($"Skipped malformed line: {line}");
                }
            }
            Console.WriteLine($"Journal loaded successfully from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}