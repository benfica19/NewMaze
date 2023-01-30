using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{

  public GameObject door1;
  public GameObject door2;
  public Collider door2_Collider;
  public GameManager gameManager;

  public Collider collectableCoin1;

  void OnTriggerEnter(Collider other)
  {
      if(other.gameObject.name == "door1"){
          Destroy(other.gameObject);
  }

      if(other.gameObject.name == "door2"){
          door2_Collider.isTrigger = false;
          collectableCoin1.isTrigger = true;
          gameManager.LoadCoin();
          Debug.Log("Door 2 Found");
  }

      if(other.gameObject.name == "collectableCoin1"){
        Debug.Log("FoundCoin");
      }




}
}
