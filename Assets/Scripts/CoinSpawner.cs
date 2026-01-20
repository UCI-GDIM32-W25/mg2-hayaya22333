using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] public GameObject coinPrefab;
    [SerializeField] private float nextCoinTime = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (nextCoinTime <= 0){
            MakeCoin();
            nextCoinTime = Random.Range(0.1f, 2f);
        }
        else{
            nextCoinTime -= Time.deltaTime;
        }
    }

    void MakeCoin(){
        Instantiate(coinPrefab, transform.position, transform.rotation);
    }
}
