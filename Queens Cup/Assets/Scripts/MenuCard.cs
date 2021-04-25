/// <summary>
/// This script can be added to a prefab to make an instance of it spipn and
/// fall towards a position below the camera before destroying itself.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCard : MonoBehaviour
{
    private float speed = 5.0f;
    private float rotationValue;
    private Vector2 target;

    private void Start()
    {
        rotationValue = Random.Range(0, 2);
        if (rotationValue == 0)
            rotationValue = -1;

        target = new Vector2(
            this.transform.position.x,
            Camera.main.ScreenToWorldPoint(
                new Vector2(
                    0,
                    Screen.height
                )).y * -1.0f - 3f);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, step);

        transform.Rotate(0, 0, rotationValue);

        if (transform.position.y <= target.y)
        {
            Destroy(this.gameObject);
        }
    }
}
