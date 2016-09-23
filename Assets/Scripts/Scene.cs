using System;
using System.Collections.Generic;

	[Serializable]
	public class Scene
	{
		private Players _players = new Players();
		private Scene[] _connected_scenes = new Scene[4];
		private string _description = "default"; 
		private int _id;
		public static List<Scene> AllScenes = new List<Scene>();
		
		public int ID {
			get{ 
				return _id;
			}
			set{
				_id = value;
			}
		}

		public string Description{ 
			get { 
				return _description;
			}
			set { 
				_description = value;
			}
		}
	    
		public Scene North { 
			get { 
			return _connected_scenes[(int)GameModel.DIRECTION.North];
			}
			set { 
			_connected_scenes[(int)GameModel.DIRECTION.North] = value;
			}
		}

		public Scene South { 
			get { 
				return _connected_scenes[(int)GameModel.DIRECTION.South];
			}
			set { 
				_connected_scenes[(int)GameModel.DIRECTION.South] = value;
			}
		}
		public Scene ()
		{
			Scene.AllScenes.Add(this);
		}
	    
	    
	}


