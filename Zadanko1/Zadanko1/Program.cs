using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class serv {
    public static void Main() {
    try {
        IPAddress ipAd = IPAddress.Parse("192.168.43.182");
       
        TcpListener myList=new TcpListener(ipAd,12964);
       
        myList.Start();        
        
        Socket s=myList.AcceptSocket();        
        
        byte[] b=new byte[1024];
        var k=s.Receive(b);
        List<string> slowo = new List<string>();        
        for (int i = 0; i < k; i++)
        {
            slowo.Add(Convert.ToChar(b[i]).ToString());
            
        }

        
        string txt = String.Join("", slowo.ToArray());
 
        ASCIIEncoding asen=new ASCIIEncoding();
        s.Send(asen.GetBytes(txt));

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=Zadanko;Integrated Security=True");
        if (con.State == ConnectionState.Closed)
            con.Open();
        SqlCommand cmd = new SqlCommand(); 
        cmd.CommandText = "Insert into Tabela(Tekst)values('" + txt + "')";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
        Console.Write("OK");
        
        s.Close();
        myList.Stop();

        Console.ReadKey();

        }
    catch (Exception e) {
        Console.WriteLine("Error..... " + e.StackTrace);
    }    
    }
    
}
