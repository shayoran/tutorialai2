using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject shellPrefab;
    public GameObject shellSpawnPos;
    public GameObject target;
    public GameObject parent;
    float speed = 15;
    float turnspeed = 2;
    bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CanShootAgain()
    {
        canShoot = true;
    }
    void Fire()
    {
        if(canShoot)
        {
            GameObject shell = Instantiate(shellPrefab, shellSpawnPos.transform.position, shellSpawnPos.transform.rotation);
            shell.GetComponent<RigidBody>().velocity = speed * this.transform.forward;
            canShoot = false;
            Invoke = ("CanShootAgain",0.2f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        Fire();

        Vector3 direction = (target.transform.position - parent.transform.position).normalized;
        Quaternion lookRotation = Quaternion lookRotation(new Vector3(direction.x, 0 , direction.z))
        parent.transform.rotation = Quaternion.slerp(parent.transform.rotation, lookRotation, Time.deltaTime * turnspeed);

        float? angle = RotateTurret();
    }

    float?RotateTurret()
    {
        float? CalculateAngle(false);
        if (angle != null)
        {
            this.transform.localEulerAngles = new Vector3(360f - (float)angle, 0f, 0f);
        }
        return angle;
    }

    float? CalculateAngle(bool low)
    {
        Vector3 targetDir = target.transform.position = this.transform.position;
        float y =targetDir.y;
        targetDir.y = 0f;
        float x = targetDir.magnitude;
        float.gravity = 9.81f;
        float sSqr = speed * speed;
        float underTheSqrRoot = (sSqr * sSqr) - gravity * (gravity * x * x + 2 * y * sSqr);

        if(underTheSqrRoot >= 0f)
        {
            float root = Mathf.Sqrt(underTheSqrRoot);
            float highAngle = sSqr + root;
            float lowAngle = sSqr - root;

            if(low)
            return (Mathf.Atan2(lowAngle, gravity * x) * Mathf.Rad2Deg);
            else
            return (Mathf.Atan2(highAngle, gravity * x) * Mathf.Rad2Deg);
        }
        else
        return null;
    }
}
