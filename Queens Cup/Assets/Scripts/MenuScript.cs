/// <summary>
/// Instantiates a prefab from the resources folder at random positions on the
/// Y-axis.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    private AudioSource menuSong;
    private string path = "Cards/MenuCard";
    private Object menuCard;

    // Start is called before the first frame update
    void Start()
    {
        menuCard = Resources.Load(path);

        Invoke("GenerateCard", Random.Range(1.0f, 5.0f));

        menuSong = GetComponent<AudioSource>();
        menuSong.Play();
        menuSong.loop = true;
    }

    void GenerateCard()
    {
        float spawnX =
                Random.Range(
                    Camera.main.ScreenToWorldPoint(
                        new Vector2(0, 0)).x,
                    Camera.main.ScreenToWorldPoint(
                        new Vector2(Screen.width, 0)).x
                );

        float spawnY =
            Camera.main.ScreenToWorldPoint(
                new Vector2(
                    0,
                    Screen.height
                )).y + 5;

        Instantiate(
            menuCard,
            new Vector2(spawnX, spawnY),
            Quaternion.Euler(0, 0, Random.Range(0, 360))
        );

        float randomTime = Random.Range(0.2f, 0.75f);
        Invoke("GenerateCard", randomTime);
    }
}
