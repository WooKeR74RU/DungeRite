using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameListener : MonoBehaviour
{
	void Start()
	{
		GameResources.Initialize();
	}
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			List<GameEntity> gameEntities = GameResources.getObjects(mousePos);
			for (int i = 0; i < gameEntities.Count; i++)
				gameEntities[i].gameObj.SetActive(false);
		}
	}
}