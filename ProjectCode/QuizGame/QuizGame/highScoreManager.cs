using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class HighScoreManager
{
    private string filePath; //file path for the high score text file

    //constructor
    public HighScoreManager(string filePath)
    {
        this.filePath = filePath;
    }

    //write the high scores to the files
    public void WriteHighScore(string name, int score)
    {
        var highScores = ReadHighScores(); //get the current scores (so the lowest can be dropped)
        highScores.Add((name, score)); //add new the tuple 
        highScores = highScores.OrderByDescending(s => s.Score).Take(5).ToList(); //get the top 5 scores

        //write values to the file
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            foreach (var highScore in highScores)
            {
                writer.WriteLine($"{highScore.Name},{highScore.Score}");
            }
        }
    }

    //read the file
    public List<(string Name, int Score)> ReadHighScores()
    {
        var highScores = new List<(string Name, int Score)>(); //list of names, score

        if (File.Exists(filePath)) //open the file
        {
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null) //read each line until the end
                {
                    var parts = line.Split(','); //split where commas are
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score)) //if 2 parts exist (name and score) make the score a int type
                    {
                        highScores.Add((parts[0], score)); //add to the list so it can be sorted
                    }
                }
            }
        }

        return highScores;
    }
}