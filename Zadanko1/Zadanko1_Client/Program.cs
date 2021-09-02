using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

public class clnt {

    public static void Main() {
        
        try {
            TcpClient tcpclnt = new TcpClient();
                        
            tcpclnt.Connect("192.168.43.182",12964);

            Console.Write("Wpisz słowo: ");

            String str=Console.ReadLine();
            Stream stm = tcpclnt.GetStream();
                        
            ASCIIEncoding asen= new ASCIIEncoding();
            byte[] ba=asen.GetBytes(str);
                       
            stm.Write(ba,0,ba.Length);
            
            byte[] bb=new byte[100];
            int k=stm.Read(bb,0,100);
            List<string> slowo = new List<string>();
            for (int i=0;i<k;i++)
                slowo.Add(Convert.ToChar(bb[i]).ToString());

            string txt = String.Join("", slowo.ToArray());
            Console.WriteLine(txt + " " + DateTime.Now.ToString("dd-MM-yyyy, HH:mm:ss"));

            tcpclnt.Close();

            Console.ReadKey();
        }
        
        catch (Exception e) {
            Console.WriteLine("Error..... " + e.StackTrace);
        }
    }

}