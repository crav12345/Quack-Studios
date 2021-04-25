using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCardMovement : MonoBehaviour
{
    private float speed = 5.0f;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        // Get random Y-pos within the boundaries of the main camera
        float spawnY =
            Random.Range(
                Camera.main.ScreenToWorldPoint(
                    new Vector2(0, 0)).y,
                Camera.main.ScreenToWorldPoint(
                    new Vector2(0, Screen.height)).y
            );
        // Get random X-pos within the boundaries of the main camera
        float spawnX =
            Random.Range(
                Camera.main.ScreenToWorldPoint(
                    new Vector2(0, 0)).x,
                Camera.main.ScreenToWorldPoint(
                    new Vector2(Screen.width, 0)).x
            );

        // Create a vector two based on the above X and Y values
        target = new Vector2(spawnX, spawnY);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
}
