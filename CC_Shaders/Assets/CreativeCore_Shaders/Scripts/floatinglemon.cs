using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatinglemon : MonoBehaviour
{

  public Material lemon;
  public Material godglow;

  public Vector3 position;
  public float moveSpeed;
  public float radius;
  public float angle;
  public float random;
    // Start is called before the first frame update
    void Start()
    {
      position = this.transform.position;



    }

    IEnumerator LEMONGLOW()
{
  this.GetComponent<MeshRenderer>().material = godglow;
    yield return new WaitForSeconds(1);
    this.GetComponent<MeshRenderer>().material = lemon;
}



    // Update is called once per frame
    void Update()
    {
      if (Random.Range(0, 500) == 1){
        StartCoroutine(LEMONGLOW());
      }




      angle += (moveSpeed / (radius * Mathf.PI * 2.0f)) * Time.deltaTime;
      angle += moveSpeed * Time.deltaTime;
      this.transform.position = new Vector3(0, Mathf.Cos(angle) +Random.Range(-0.5f, 0.5f), Mathf.Sin(angle) +Random.Range(-0.5f, 0.5f)) * radius + position;
    }
}
