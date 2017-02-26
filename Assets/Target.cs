using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        GameObject[] projectiles = GameObject.FindGameObjectsWithTag("Projectile");

        foreach (GameObject g in projectiles)
        {
            if (this.gameObject.GetComponent<BoxCollider>().bounds.Intersects(g.GetComponent<CapsuleCollider>().bounds)) {
                g.BroadcastMessage("hit");
                this.gameObject.SetActive(false);
                Destroy(this);
                break;
            }
        }
	}
}
