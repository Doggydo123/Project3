using UnityEngine;

public class SpriteSpawner : MonoBehaviour
{
    public GameObject spritePrefab; // Reference to the sprite prefab to spawn
    public int numberOfSprites = 10; // Number of sprites to spawn
    public Vector2 spawnRange = new Vector2(-5f, 5f); // Range of spawn positions

    void Start()
    {
        // Spawn multiple sprites
        for (int i = 0; i < numberOfSprites; i++)
        {
            SpawnSprite();
        }
    }

    void SpawnSprite()
    {
        // Generate random position within the spawn range
        float randomX = Random.Range(spawnRange.x, spawnRange.y);
        float randomY = Random.Range(spawnRange.x, spawnRange.y);
        Vector3 spawnPosition = new Vector3(randomX, randomY, -7f);

        // Instantiate the sprite at the random position
        GameObject spriteInstance = Instantiate(spritePrefab, spawnPosition, Quaternion.identity);

        // Optionally, you can do further customization or initialization of the spawned sprite here
    }
}