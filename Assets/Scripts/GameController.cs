using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {
	public static GameController instance;
	public Camera cam;
    public Vector2 upperCorner;
    public Vector2 targeCamtWidth;
    public float maxWidth;
    public float maxHeigth;
    public bool gameOver;
    public GameObject gameOverText;
    public float bulletVSpeed;
    public float bulletHSpeed;

    // Use this for initialization && guarantee that there's
    // only one instance of the GameController
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        if (cam == null)
        {
            cam = Camera.main;
        }

        upperCorner = new Vector2(Screen.width, Screen.height);
        targeCamtWidth = GameController.instance.cam.ScreenToWorldPoint(upperCorner);
        maxWidth = targeCamtWidth.x;
        maxHeigth = targeCamtWidth.y;
    }
	
	// Update is called once per frame
	void Update () {
		//Restart the Game
		if (gameOver && Input.anyKey) {
			//Make unity reload the scene currenctly active
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
    public void Endgame() {
        gameOver = true;
        gameOverText.SetActive(true);
    }
}
