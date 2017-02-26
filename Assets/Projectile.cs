using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float timer;
    public float timeToReachDest;
    Vector3 startPosition;
    Vector3 endPosition;

    void Start()
    {
        timer = 0.0F;
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime / timeToReachDest;
        transform.position = Vector3.Lerp(startPosition, endPosition, timer);
        if (transform.position == endPosition)
        {
            this.gameObject.SetActive(false);
            Destroy(this);
        }
	}

    public void SetTarget(GameObject target)
    {
        transform.position = Camera.main.transform.position;
        transform.LookAt(target.transform.position);
        timer = 0;
        startPosition = this.gameObject.transform.position;
        endPosition = target.transform.position;
        timeToReachDest = 4;

        //this.gameObject.transform.Rotate(Vector3.right, 90);
        //speed = ((target - this.gameObject.transform.position).normalized) / 15;
        //transform.forward = speed;
    }

    public void hit()
    {
        this.gameObject.SetActive(false);
        Destroy(this);
    }
}
