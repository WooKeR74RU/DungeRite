using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameResources
{
	static int width;
	static int height;
	static List<List<Pair<GameEntity, GameEntity>>> map = new List<List<Pair<GameEntity, GameEntity>>>();
	static int objectsCounter = 1;
	static String[] characterAnim = { "characterFront", "characterLeft", "characterRight", "characterBack" };
	static String[] furnitureAnim = { "boiler", "torch" };
	static String[] furnitureImage = { "atlas_181", "atlas_264", "atlas_266", "atlas_406", "atlas_440", "atlas_444" };
	static String[] destructibleImage = { "atlas_407", "atlas_408", "atlas_445" };
	static String[] wall = { "123", "231" };
	static String[] floor = { "123", "231" };
	static String[] exit = { "123", "231" };
	static String[] movingBrick = { "123", "231" };
	static String[] water = { "123", "231" };
	static String[] ice = { "123", "231" };
	static String[] precipice = { "123", "231" };
	static String[] spikes = { "123", "231" };
	static String[] teleport = { "123", "231" };
	static String[] collect = { "123", "231" };
	static String[] arrow = { "123", "231" };
	static void LoadTextures()
	{
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				GameEntity obj = map[i][j].first;
				obj.gameObj = new GameObject("Object #" + objectsCounter);
				obj.gameObj.AddComponent<SpriteRenderer>();
				Animator animator = obj.gameObj.AddComponent<Animator>();
				if (obj.logicType == 'U')
				{

				}
			}
		}
	}
	public static void InitializeMap(String mapPath)
	{
		String[] textMap = (Resources.Load<TextAsset>(mapPath) as TextAsset).text.Split(new char[] { '\n' });
		height = textMap.Length / 2 - 1;
		width = textMap[0].Length;
		for (int i = 0; i < height; i++)
		{
			map.Add(new List<Pair<GameEntity, GameEntity>>());
			for (int j = 0; j < width; j++)
				map[i].Add(new Pair<GameEntity, GameEntity>());
		}
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
				map[i][j].first = new GameEntity(textMap[i][j]);
		}
		for (int i = height + 1; i < 2 * height + 1; i++)
		{
			for (int j = 0; j < width; j++)
				map[i][j].second = new GameEntity(textMap[i][j]);
		}
	}
}