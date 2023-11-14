using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public int damage;
    public float fireRate;
    private float nextFire;
    public Camera camera;

    [Header("VFX")]
    public GameObject hitVFX;

    public GameObject hitPlayerVFX;

    void Update() {
        if (nextFire > 0)
            nextFire -= Time.deltaTime;
        if (Input.GetButton("Fire1") && nextFire <= 0) {
            nextFire = 1 / fireRate;
            Fire();
        }
    }

    void Fire() {
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);

        RaycastHit hit;

        if (Physics.Raycast(ray.origin, ray.direction, out hit, 100f)) {
            
            if (hit.transform.gameObject.GetComponent<Health>()) {
                PhotonNetwork.Instantiate(hitPlayerVFX.name, hit.point, Quaternion.identity);
                hit.transform.gameObject.GetComponent<PhotonView>().RPC("TakeDamage", RpcTarget.All, damage);
            } else {
                PhotonNetwork.Instantiate(hitVFX.name, hit.point, Quaternion.identity);
            }
        }
        Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 1f);
    }
}
