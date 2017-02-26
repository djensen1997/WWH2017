using UnityEngine;
using SocketIO;
using WebSocketSharp;

public class InputManager : MonoBehaviour {
    
    //public GameObject p;
    //public GameObject gaze;

    //UdpClient udpServer;

    GameObject go;
    SocketIOComponent socket;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Oppenned)");
        go = GameObject.Find("SocketIO");
        socket = go.GetComponent<SocketIOComponent>();
        socket.Connect();
        socket.On("Test", (data) =>
         {
             Debug.Log("Socket.on");
         });
    }

    //private void SocketOpened(object sender, MessageEventArgs e)
    //{
    //    //invoke when socket opened
    //}

    //private void SocketMessage(object sender, MessageEventArgs e)
    //{
    //    if (e != null && e.Event == "message")
    //    {
    //        string msg = e.Message.MessageText;
    //        if (msg.Equals("waveIn"))
    //        {
    //            Debug.Log("Wave In");
    //            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Target"))
    //            {
    //                g.SetActive(false);
    //            }
    //        }
    //        else
    //        {
    //            Debug.Log("Wave Out");
    //            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Target"))
    //            {
    //                g.SetActive(true);
    //            }
    //        }
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        //(SocketIOEvent e) =>
        //{
        //    e.data.
        //}
        //socket.socket.OnMessage += {

        //}

        //IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("141.219.235.66"), 8765);
        //byte[] data = udpServer.Receive(ref remoteEP);
        //Debug.Log(data.ToString());
        //string result = System.Text.Encoding.UTF8.GetString(data);
        //if (result.Equals("waveIn")) {
        //    Debug.Log("Wave In");
        //    foreach (GameObject g in GameObject.FindGameObjectsWithTag("Target"))
        //    {
        //       g.SetActive(false);
        //    }
        //} else {
        //    Debug.Log("Wave Out");
        //    foreach (GameObject g in GameObject.FindGameObjectsWithTag("Target"))
        //    {
        //        g.SetActive(true);
        //    }
        //}
    }
}
