using UnityEngine;
using System.IO.Ports;
using UnityEngine;

public class VMScript : MonoBehaviour
{

    public string portName = "COM3";
    public int baudRate = 9600;
    private SerialPort port;

    public int noiseVolume = 0;
    public int lightVolume = 0;

    public int noisePeak = 0;
    public int lightPeak = 0;

   
   void Start()
   {
        Debug.Log("VMScript.Start() called");

        try
       {
           port = new SerialPort(portName, baudRate); //set the port
           port.ReadTimeout = 50; //If you don't find it in this amount of time move on
           port.Open(); //Try to open the port

           Debug.Log($"Serial port {portName} opened at {baudRate} baud");

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

            if (tag == "SENSOR")
            {
                noiseVolume = int.Parse(dataParts[1]);
                lightVolume = int.Parse(dataParts[2]);
                Debug.Log(noiseVolume + " " + lightVolume);

            }
            else if (tag == "PEAK")
            {
                noisePeak = int.Parse(dataParts[1]);
                lightPeak = int.Parse(dataParts[2]);
                Debug.Log(noisePeak + " " + lightPeak);
            }

        }
        catch (System.TimeoutException)
        {
            //Just catch the exeption
        }
        catch (System.Exception e) {
            Debug.LogWarning(e);
        }
   }

    private void OnApplicationQuit()
    {
        if (port != null && port.IsOpen)
        {
            port.Close();
            port.Dispose();
        }
    }
}

