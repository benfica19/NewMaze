using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public GameManager gameManager;
    public bool isRedColor = false;
    public bool isBlueColor = false;

    public AnalyticsManager game_analyticsManager;
    private GameObject blueCube;
    private GameObject redCube;
    private GameObject pushBase;

    public float Force = 2000f;
    public Rigidbody rb;

    public Collider blueplatform_Collider;
    public Collider redplatform_Collider;

    void OnTriggerEnter(Collider other)
    {

      if(other.gameObject.tag == "RedCoin")
      {

          Destroy(other.gameObject);
          blueCube  = GameObject.Find("BlueCoin");
          Destroy(blueCube);
          gameManager.LoadColoredGrounds();
          game_analyticsManager.SendEvent("RED COIN COLLECTED LEVEL 1");
          isRedColor = true;

      }

      if(other.gameObject.tag == "BlueCoin")
      {

          Destroy(other.gameObject);
          redCube  = GameObject.Find("RedCoin");
          Destroy(redCube);
          gameManager.LoadColoredGrounds();
          game_analyticsManager.SendEvent("BLUE COIN COLLECTED LEVEL 1");
          isBlueColor = true;
      }

      if(other.gameObject.name == "RedPlatform" && isRedColor)
     {
           Destroy(other.gameObject);
      }

      if(other.gameObject.name == "RedPlatform" && !isRedColor){
          redplatform_Collider.isTrigger = false;
      }



      if(other.gameObject.name == "BluePlatform" && isBlueColor)
     {
           Destroy(other.gameObject);
      }
      if(other.gameObject.name == "BluePlatform" && !isBlueColor){
            blueplatform_Collider.isTrigger = false;
        }

    }


}
