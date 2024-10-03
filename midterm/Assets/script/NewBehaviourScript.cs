// using System.Collections.Generic;

// void Update()
// {
//     if (health <= 0) {
//         // Trigger game over
//     } else if (health < 50) {
//         // Change player color to indicate low health
//     }
// }


// public class PlayerController : MonoBehaviour {
//     private List<string> collectedItems = new List<string>();

//     void OnTriggerEnter2D(Collider2D collision) {
//         if (collision.CompareTag("Collectible")) {
//             collectedItems.Add(collision.gameObject.name);
//             Destroy(collision.gameObject); // Remove the collectible from the scene
//         }
//     }
// }

// public GameObject[] enemyPrefabs; // Assign different enemy prefabs in the Inspector

// void SpawnEnemies() {
//     for (int i = 0; i < enemyPrefabs.Length; i++) {
//         Instantiate(enemyPrefabs[i], new Vector2(i * 2, 0), Quaternion.identity);
//     }
// }
