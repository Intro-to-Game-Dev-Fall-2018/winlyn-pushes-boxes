﻿/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class uhhhh : MonoBehaviour
{

	[SerializeField] private GameObject[] tilePrefabs;

	public float TileSize
	{
		get
		{
			return tilePrefabs[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		CreateLevel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void CreateLevel()
	{
		string[] mapData = ReadLevelText();

		int mapX = mapData[0].ToCharArray().Length;

		int mapY = mapData.Length;

		Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));

		for (int y = 0; y < mapY; y++)
		{
			char[] newTiles = mapData[y].ToCharArray();

			for (int x = 0; x < mapX; x++)
			{
				PlaceTile(newTiles[x].ToString(), x, y, worldStart);
			}
		}
	}

	private void PlaceTile(string tileType, int x, int y, Vector3 worldStart)
	{
		int tileIndex = int.Parse(tileType);

		GameObject newTile = Instantiate(tilePrefabs[tileIndex]);
		
		newTile.transform.position = new Vector3(worldStart.x + (TileSize * x), worldStart.y - (TileSize * y));
	}

	private void Level()
	{
		string[] mapData = ReadLevelText();
	}

	private string[] ReadLevelText()
	{
		TextAsset data = Resources.Load("Level1") as TextAsset;

		string data = bindData.text.Replace(Environment.NewLine, string.Empty);

		return data.Split('-');
	}
}*/