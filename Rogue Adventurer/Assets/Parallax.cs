using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Code found from Brackeys on Youtube
public class Parallax : MonoBehaviour
{
     
    public Transform[] backrounds;       // array of the backround images
    private float[] parallaxScales;      //proportion of backround movement
    public float smoothing = 1;         //how smooth parallax is

    private Transform cam;              //reference main camera transform
    private Vector3 previousCamPos;     //position of the cam from the previous frame

    // called before start
    void Awake()
    {
        cam = Camera.main.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        previousCamPos = cam.position;

        parallaxScales = new float[backrounds.Length]; 
        //assigning backound z position to scale
        for( int i = 0; i < backrounds.Length; i++)
        {
            parallaxScales[i] = backrounds[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < backrounds.Length; i++)
        {
            //set parallax as opposite of camera movement
            float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

            //set a target x pos (current position + parallax)
            float backroundTargetPosX = backrounds[i].position.x + parallax;

            //create target position (backrounds current position with target x)
            Vector3 backroundTargetPos = new Vector3(backroundTargetPosX, backrounds[i].position.y, backrounds[i].position.z);

            //fade between current and target position using lerp
            backrounds[i].position = Vector3.Lerp(backrounds[i].position, backroundTargetPos, smoothing * Time.deltaTime);
        }

        //set previous cam pos to current pos
        previousCamPos = cam.position;
    }
}
