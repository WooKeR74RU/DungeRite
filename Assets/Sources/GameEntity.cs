using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameEntity
{
	public GameObject gameObj;
	public char logicType;
	static int objectsCounter = 1;
	public GameEntity(char logicType)
	{
		this.logicType = logicType;
		gameObj = new GameObject("Object #" + objectsCounter);
		gameObj.AddComponent<SpriteRenderer>();
		objectsCounter++;
	}
}