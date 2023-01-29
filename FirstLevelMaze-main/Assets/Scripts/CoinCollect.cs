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

    //public Transform redGround;
    //public Transform blueGround;

    void OnTriggerEnter(Collider other)
    {

      if(other.gameObject.tag == "RedCoin")
      {

          Destroy(other.gameObject);
          gameManager.LoadColoredGrounds();

      }

      if(other.gameObject.name == "CHECKRED")
      {
          Destroy(other.gameObject);
          blueCube  = GameObject.Find("CHECKBLUE");
          Destroy(blueCube);
          isRedColor = true;
          gameManager.LoadColoredGrounds();
          game_analyticsManager.SendEvent("RED COIN COLLECTED LEVEL 1");
      }

      if(other.gameObject.name == "CHECKBLUE")
      {
          Destroy(other.gameObject);
          redCube  = GameObject.Find("CHECKBLUE");
          Destroy(redCube);
          isBlueColor = false;
          game_analyticsManager.SendEvent("BLUE COIN COLLECTED LEVEL 1");
          gameManager.LoadColoredGrounds();
      }

      if(other.gameObject.name == "RedPlatform" && isRedColor == true)
      {
          Destroy(other.gameObject);
      }

      if(other.gameObject.name == "BluePlatform" && isBlueColor == true)
      {
          Destroy(other.gameObject);
      }

      if(other.gameObject.name == "Push")
      {
        pushBase  = GameObject.Find("Push");
        rb.AddForce(0, 0, Force * Time.deltaTime);

      }

    }
}
