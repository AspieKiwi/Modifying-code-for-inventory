using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.IO;



using System.Text;

// Is this a factory?
public static class GameModel
{

	private static String _name;
	private static Player _player = new Player();
	public enum DIRECTION  {North, South, East, West};
	private static Scene _start_scene; // ??
	public static Players PlayersInGame = new Players();

	public static Scene Start_scene{
		get 
		{ 
			return _start_scene;  
		}
		set{
			_start_scene = value; 
		}

	}

	public static string Name{
		get 
		{ 
			return _name;  
		}
		set{
			_name = value; 
		}

	}

	public static Player currentPlayer
	{
		get
		{
			return _player;
		}
		set
		{
			_player = value;
		}

	}
	public static void go(DIRECTION pDirection)
	{
		currentPlayer.Move(pDirection);
	}

	public static void makeScenes()
	{
		Scene tmp; 
		DataService theService = new DataService();

		// uncomment the following two lines to start with an empty database
		//if(theService.DbExists("GameNameDb"))
		//	theService.deleteDatabaseFile();

		// Watch out DbExists has a side effect!
		if(theService.DbExists("GameNameDb"))
		{
			theService.Connect();
			theService.LoadScenes();
			currentPlayer.InitialisePlayerState();
			currentPlayer.CurrentScene = Scene.AllScenes[0];
		}
		else
		{
			Start_scene = new Scene();

			tmp = new Scene();
			Start_scene.ID = 1;
			Start_scene.North = tmp;
			Start_scene.Description = " You are lost in a forest" ;

			tmp.ID = 2;
			tmp.Description = " You are in the Mall" ;
			tmp.South = Start_scene;


			tmp.North = new Scene ();
			tmp.North.ID = 3;
			tmp.North.Description = "You fell off a cliff";
			tmp.North.South = tmp;// ??

			currentPlayer.InitialisePlayerState();
			currentPlayer.CurrentScene = Start_scene;


			theService.Connect();
			theService.SaveScenes();
		}

	}


}

