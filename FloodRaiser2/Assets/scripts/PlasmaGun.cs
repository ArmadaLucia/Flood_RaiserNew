using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlasmaGun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    //we want to shoot the 'ray' from the position of our camera
    public Camera fpsCam;
    public ParticleSystem DustColors;
    public ParticleSystem BollBullet;
    public GameObject impactEffect;
    public float ImpactForce = 30f;

    public GameObject Note;
    public Rigidbody rigid;

    // Update is called once per frame
    void Update()
    {

        //GetButtonDOWN talks about while pressing it
        //GetButtonUP talks about when releasing button
        //Fire1 is Unity function meaning: left mouse button
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Note.SetActive(false);
            rigid.isKinematic = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;


        }
    }

        void Shoot()
        {
            DustColors.Play();
            BollBullet.Play();

            //RaycastHit gathers all info about shooting a ray
            //transform talks about the x, y, z position of an object
            //out hit calls up the ray to give away that it hit something
            //range will here say that after 100f the ray will disapear into the air
            RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                //only punching when hitting a target
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }

                // null is letterlijk niets, geen waarde
                // -hit.normal betekend naar achteren worden geschoten
                if (hit.collider.tag == "OpalBlock" && hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * ImpactForce);
                }

                 if (hit.collider.tag == "HangOpalblock" && hit.rigidbody != null)
                {
                Debug.Log("Gravity On");
                hit.rigidbody.useGravity = true;
                }

                if (hit.collider.tag == "Note")
                {
                    Debug.Log("Open Note");
                    Note.SetActive(true);
                    rigid.isKinematic = true;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    DustColors.Stop();
                    BollBullet.Stop();
            }

                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Debug.Log("Impact.Detected");

                Destroy(impactGO, 2f);
            }

        }
    }
