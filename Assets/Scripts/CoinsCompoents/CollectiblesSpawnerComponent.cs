using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesSpawnerComponent : MonoBehaviour
{
    [SerializeField] CoinBehaviour coinObject;
    [SerializeField] HealBehaviour healObject;
    [SerializeField] int minCoinAmount = 1;
    [SerializeField] int maxCoinAmount = 5;
    [SerializeField] float pushForce = 2f;
    [SerializeField] float HealDropChance = 0.05f;
    public void SpawnCollectibles()
    {
        if (Random.Range(0f, 1f) < HealDropChance) SpawnHeal();
        SpawnCoins();
    }

    private void SpawnHeal()
    {
        GameObject heal = Instantiate(healObject, transform.position, Quaternion.identity).gameObject;
        float xDir = Random.Range(-1f, 1f);
        float yDir = Random.Range(-1f, 1f);
        Vector2 direction = new Vector2(xDir, yDir);
        heal.GetComponent<Rigidbody2D>().AddForce(direction * pushForce, ForceMode2D.Impulse);
    }

    private void SpawnCoins()
    {
        int coinAmount = Random.Range(minCoinAmount, maxCoinAmount + 1);
        for (int i = 0; i < coinAmount; i++)
        {
            GameObject coin = Instantiate(coinObject, transform.position, Quaternion.identity).gameObject;
            float xDir = Random.Range(-1f, 1f);
            float yDir = Random.Range(-1f, 1f);
            Vector2 direction = new Vector2(xDir, yDir);
            coin.GetComponent<Rigidbody2D>().AddForce(direction * pushForce, ForceMode2D.Impulse);
        }
    }
}
