using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    public target_gen tar_object;
    public Collider2D bodi;
    
    [SerializeField]GameObject[] fruitprefab;
    [SerializeField]float secondspawn=1f;
    [SerializeField]float minTras;
    [SerializeField]float maxTras;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fruitspawn());
        tar_object=GameObject.FindGameObjectWithTag("ftarget").GetComponent<target_gen>();
        

    }
    IEnumerator Fruitspawn(){
        while(true){
            var wanted=Random.Range(minTras,maxTras);
            var position= new Vector3(wanted,transform.position.y);
            GameObject gameObject=Instantiate(fruitprefab[Random.Range(0,fruitprefab.Length)],
            position,Quaternion.identity);
            yield return new WaitForSeconds(secondspawn);
            Destroy(gameObject,3f);
        }
    }
    

    

    // Update is called once per frame
   
    

    public void Update()
    {
        
   
        
        
        
    }
    public void Awake(){
       
     

    }
    public void own_func(){
        
        
       
        


    }
}