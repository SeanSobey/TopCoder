using System;

public class ABoardGame
{
    public string whoWins(string[] board)
	{
        var regionCount = board.Length / 2;
        var Alice = new int[regionCount];
        var Bob = new int[regionCount];
        
        var rowIndex = board.Length / 2;
        foreach (var row in board)
        {
            var columnIndex = row.Length / 2;
            foreach(var cell in row)
            {
                var region = Math.Max(Math.Abs(rowIndex), Math.Abs(columnIndex));
				
                if (cell == 'A')
                    Alice[region - 1]++;
                else if (cell == 'B')
                    Bob[region - 1]++;
                
                columnIndex--;
                if(columnIndex == 0)
                    columnIndex--;
            }

            rowIndex--;
            if(rowIndex == 0)
                rowIndex--;
        }
        
        var resultCount = 0;
        for (var i = 0; i < regionCount; i++)
        {
            if (Alice[i] > Bob[i])
                resultCount++;            
            else if (Alice[i] < Bob[i])
                resultCount--;
        }
        
        if (resultCount > 1)
            return "Alice";
        if (resultCount < 1)
            return "Bob";
        return "Draw";
    }
}