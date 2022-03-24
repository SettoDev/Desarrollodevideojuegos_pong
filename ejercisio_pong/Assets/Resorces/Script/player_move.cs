using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float screenHeigh, screenwidt, distanciaZ;
    public Camera m_maincamera;
    public GameObject m_cube1, m_cube2, m_cube3, m_cube4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        screenHeigh = Screen.height;
        screenwidt = Screen.width;
        Debug.Log("tamaña ancho: " + screenwidt + "  " + "tamaño alto: " + screenHeigh);

        Vector3 esquinaabajoz = new Vector3(0, 0, distanciaZ);
        Vector3 posiciondelcubo1 = m_maincamera.ScreenToWorldPoint(esquinaabajoz);
        m_cube1.transform.position = posiciondelcubo1;

        Vector3 esquinaabajoD = new Vector3(screenwidt, 0, distanciaZ);
        Vector3 posiciondelcubo2 = m_maincamera.ScreenToWorldPoint(esquinaabajoD);
        m_cube2.transform.position = posiciondelcubo2;

        Vector3 esquinaarribaz = new Vector3(0, screenHeigh, distanciaZ);
        Vector3 posiciondelcubo3 = m_maincamera.ScreenToWorldPoint(esquinaarribaz);
        m_cube3.transform.position = posiciondelcubo3;

        Vector3 esquinaarribaD = new Vector3(screenwidt, screenHeigh, distanciaZ);
        Vector3 posiciondelcubo4 = m_maincamera.ScreenToWorldPoint(esquinaarribaD);
        m_cube4.transform.position = posiciondelcubo4;




        //puntero del mouse-->
        Vector3 mousePos = Input.mousePosition;
        {
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);
        }
        if (Input.GetButtonDown("Fire1"))
        {
           
        }

    }

    private void OnDrawGizmos()
    {
        Vector3 centro_gizmo = new Vector3(0,0,5f);
        float anchocubo = Mathf.Abs(m_cube1.transform.position.x) + Mathf.Abs(m_cube2.transform.position.x);
        float altocubo = Mathf.Abs(m_cube1.transform.position.y) + Mathf.Abs(m_cube4.transform.position.y);
        Gizmos.DrawWireCube(centro_gizmo, new Vector3(anchocubo , altocubo, distanciaZ));
    }

}
