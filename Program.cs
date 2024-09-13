static string GetEnjoymentLevel()
//Prompts the user for the enjoyment level of the game they want to attend and returns the value *if it matches*
{
Console.WriteLine("What level of enjoyment do you want? Possible answers are \"Boring\", \"Average\", \"Fun\", and \"Epic\".");
string response = $"{Console.ReadLine()}";
while (response != "Boring" && response != "Average" && response != "Fun" && response != "Epic")
{
	Console.WriteLine("Possible answers are \"Boring\", \"Average\", \"Fun\", and \"Epic\". Please try again.");
	response = $"{Console.ReadLine()}";
}
return response;
}

static string GetStadiumRecommendation(string enjoymentLevel)
//Determines the best stadium to attend based off the enjoyment level and returns it.
{
	return enjoymentLevel switch
	{
		"Boring" => "Neyland Stadium",
		"Average" => "Jordan-Hare Stadium",
		"Fun" => "Tiger Stadium",
		"Epic" => "Saban Field at Bryant-Denny Stadium",
		_ => throw new Exception("Error: The enjoyment level is invalid.")
	};
}

static string GetGameRecommendation(string stadium)
//Determines the best game to attend based on the stadium given and returns it.
{
	return stadium switch
	{
		"Neyland Stadium" => "Kent State",
		"Jordan-Hare Stadium" => "Kentucky",
		"Tiger Stadium" => "Alabama",
		"Saban Field at Bryant-Denny Stadium" => "Auburn",
		_ => throw new Exception("Error: The stadium name is invalid.")
	};
}

static void DisplayStadiumDetails(string stadium, string game)
//Returns a message detailing the college stadium, including the name of the stadium and the best game to attend.
{
Console.WriteLine($"You should attend {stadium} for the game vs {game}!");
}


string finalEnjoymentLevel = GetEnjoymentLevel();
string finalStadium = GetStadiumRecommendation(finalEnjoymentLevel);
string finalGame = GetGameRecommendation(finalStadium);
DisplayStadiumDetails(finalStadium, finalGame);