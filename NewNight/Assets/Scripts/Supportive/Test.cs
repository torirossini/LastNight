﻿
using System.Collections.Generic;
using Ui;
using UnityEngine;

namespace Supportive
{
	public class Test : MonoBehaviour
	{
		[SerializeField] private string pathName;
		[SerializeField] private int _index;
		[SerializeField] private Vector3 _spaceInScreen;
		[SerializeField] private List<GameObject> _objects;
		

		[SerializeField] private bool _generate = false;
		[SerializeField] private bool _eliminate = false;
		[SerializeField] private bool _transfer = false;
		[SerializeField] private bool _clearAll = false;


		void Update()
		{
			
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				UiManager.instance.ZoomOut();
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				UiManager.instance.SwitchBackground(1);
			}

			if (Input.GetMouseButtonDown(0))
			{
				Vector2 direction = new Vector2(2*Input.mousePosition.x/Screen.width-1,2*Input.mousePosition.y/Screen.height-1);
				print(direction);
				UiManager.instance.SwitchBackground(1,direction);
			}
			
			// the block below is to test Coordinate class and UiManager.Generate and UiItem.Transfer
			/*
			if (_generate)
			{
				_generate = false;
				GameObject newItem = Ui.UiManager.instance.Generate(pathName,_index, _spaceInScreen, true).gameObject;
				_objects.Add(newItem);
				
			}

			if (_eliminate)
			{
				_eliminate = false;
				Destroy(_objects[_index]);
				_objects.RemoveAt(_index);

			}

			if (_transfer)
			{
				_transfer = false;
				_objects[_index].GetComponent<UiItem>().Transfer(Coordinate.instance.Screen2Space(_spaceInScreen),true,true);
			}

			if (_clearAll)
			{
				_clearAll = false;
				for (int i = 0; i < _objects.Count; i++)
				{
					Destroy(_objects[i]);
				}
				_objects.Clear();
			}*/
		}
	}
}
