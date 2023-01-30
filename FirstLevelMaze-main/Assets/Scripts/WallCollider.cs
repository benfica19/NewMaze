using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{

  public GameObject door1;


  void OnTriggerEnter(Collider other)
  {
      if(other.gameObject.name == "door1"){
          Destroy(other.gameObject);
  }
}

}
