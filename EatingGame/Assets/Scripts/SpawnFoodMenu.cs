using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFoodMenu : MonoBehaviour
{
    public GameObject apple;
    public GameObject banana;
    public GameObject egg;
    public GameObject strawberry;

    private Vector2 screenBounds;
    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(appleWave());
        StartCoroutine(bananaWave());
        StartCoroutine(eggWave());
        StartCoroutine(strawberryWave());
    }
    private void spawnApple() 
    {
        GameObject a = Instantiate(apple) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, -1), screenBounds.y * 2);
    }
    private void spawnBanana()
    {
        GameObject a = Instantiate(banana) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, -1), screenBounds.y * 2);
    }
    private void spawnEgg()
    {
        GameObject a = Instantiate(egg) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, -1), screenBounds.y * 2);
    }
    private void spawnStrawberry()
    {
        GameObject a = Instantiate(strawberry) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, -1), screenBounds.y * 2);
    }
    IEnumerator appleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnApple();
        }
    }
    IEnumerator bananaWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnBanana();
        }
    
    }
    IEnumerator eggWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnEgg();
        }

    }
    IEnumerator strawberryWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnStrawberry();
        }

    }

}
