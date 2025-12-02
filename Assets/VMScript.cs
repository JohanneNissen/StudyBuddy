using UnityEngine;
using System.IO.Ports;

public class VMScript : MonoBehaviour
{

    public string portName = "COM3";
    public int baudRate = 9600;
    private SerialPort port;

    public int noiseVolume = 0;
    public int LEDstate = 1;
    public int peak = 0;

    void Start()
    {
        try
        {
            port = new SerialPort(portName, baudRate); //set the port
            port.ReadTimeout = 50; //If you don't find it in this amount of time move on
            port.Open(); //Try to open the port

        } catch (System.Exception e)
        {
            Debug.LogError("Could not open port: " + portName + " Error message: " + e);
        }
    }

    void Update()
    {
        if (port == null || !port.IsOpen) //If port is not available just stop
        {
            return;
        }

        try
        {
            string data = port.ReadLine();
            Debug.Log(data);

            string[] dataParts = data.Split(',');

            if (dataParts.Length == 0)
            {
                return;
            }

            string tag = dataParts[0];

            if(tag == "SENSOR")
            {
                noiseVolume = int.Parse(dataParts[1]);
                LEDstate = int.Parse(dataParts[2]);

            } else if(tag == "PEAK")
            {
                peak = int.Parse(dataParts[1]);
            }

        } catch (System.TimeoutException)
        {
            //Just catch the exeption
        };
    }
}
