using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawns : MonoBehaviour
{
    [SerializeField]GameObject[] fruitprefab;
    [SerializeField]float secondspawn=0.5f;
    [SerializeField]float minTras;
    [SerializeField]float maxTras;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fruitspawn());

    }
    IEnumerator Fruitspawn(){
        while(true){
            var wanted=Random.Range(minTras,maxTras);
            var position= new Vector3(wanted,transform.position.y);
            GameObject gameObject=Instantiate(fruitprefab[Random.Range(0,fruitprefab.Length)],
            position,Quaternion.identity);
            yield return new WaitForSeconds(secondspawn);
            Destroy(gameObject,5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
