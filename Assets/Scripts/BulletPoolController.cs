using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolController : MonoBehaviour {

	public GameObject bulletPrefab;
	private GameObject[] bullets;

	public int bulletPoolSize;
	private Vector2 bulletPoolPosition;

	private float timeSinceLastSpawned;
	public float spawnRate;
	private int currBullet = 0;

	private float maxW;
	private float[] spawnXPositions;

	// Use this for initialization
	void Start () {
		bulletPoolPosition = new Vector2 (0, -(GameController.instance.maxHeigth + 10));
		timeSinceLastSpawned = 0.0f;
		currBullet = 0;
		maxW = GameController.instance.maxWidth;
		spawnXPositions = new float[] {-(maxW - (maxW / 3)), 0, (maxW - (maxW / 3))};

		bullets = new GameObject[bulletPoolSize];
		for (int i = 0; i < bulletPoolSize; i++) {
			bullets[i] = (GameObject)Instantiate (bulletPrefab, bulletPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawned += Time.deltaTime;

		if (!GameController.instance.gameOver && timeSinceLastSpawned >= spawnRate) {
			timeSinceLastSpawned = 0f;

			int r = Random.Range(0, spawnXPositions.Length);

			bullets [currBullet].transform.position = new Vector2 (spawnXPositions[r], bulletPoolPosition.y);
			currBullet++;

			if (currBullet >= bulletPoolSize) {
				currBullet = 0;
			}
		}
	}
}
