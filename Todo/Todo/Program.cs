﻿using Spectre.Console;
using Todo.Services;

namespace Todo;

internal class Program
{
	public static void Main()
	{
		var viewData = new ViewData();
		viewData.DisplayTodoTable();

		var option = DisplayMainMenu();
		switch (option)
		{
			case "Add new":
				AddItem.Init();
				break;
			case "Update":
				break;
			case "Delete":
				break;
			case "Exit":
				Environment.Exit(1);
				break;
		}
	}

	private static string DisplayMainMenu()
	{
		return AnsiConsole.Prompt(
			new SelectionPrompt<string>()
				.AddChoices([
					"Add new",
					"Update",
					"Delete",
					"Exit"
				]));
	}
}