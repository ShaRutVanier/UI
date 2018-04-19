using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentLocation : MonoBehaviour
{
	List<string> Floor_1 = new List<string> {"Floor 1" , "101" , "102"};

	public Dropdown dropdown;
	public Text Selected_Room;

	public void Dropdown_IndexChanged(int index)
	{
		Selected_Room.text = Floor_1 [index];
	}

	void Start()
	{
		dropdown.AddOptions (Floor_1);
	}

}
/*
	List<string> Floor_1 = new List<string> {"Floor 1" , "101" , "102"};
		
	public Dropdown dropdown;

	public Text SelectedRoom;

	public void DropdownIndex(int index)
	{
		SelectedRoom.text = Floor_1[index];
	}

}

*/