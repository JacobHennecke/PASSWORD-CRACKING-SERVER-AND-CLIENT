using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace PasswordCrackingServer
{
    internal class Server
    {
        public static List<string> Clients = new List<string>();
        public static List<string> Results = new List<string>();

        #region PROPS

        public static string C1 { get; set; }
        public static string C2 { get; set; }
        public static string C3 { get; set; }
        public static string C4 { get; set; }
        public static string C5 { get; set; }
        public static string C6 { get; set; }
        public static string C7 { get; set; }
        public static string C8 { get; set; }
        public static string C9 { get; set; }
        public static string C10 { get; set; }
        public static string C11 { get; set; }
        public static string C12 { get; set; }
        public static string C13 { get; set; }
        public static string C14 { get; set; }
        public static string C15 { get; set; }
        public static string C16 { get; set; }
        public static string C17 { get; set; }
        public static string C18 { get; set; }
        public static string C19 { get; set; }
        public static string C20 { get; set; }
        public static string C21 { get; set; }
        public static string C22 { get; set; }
        public static string C23 { get; set; }
        public static string C24 { get; set; }
        public static string C25 { get; set; }
        public static string C26 { get; set; }
        public static string C27 { get; set; }
        public static string C28 { get; set; }
        public static string C29 { get; set; }
        public static string C30 { get; set; }
        public static string C31 { get; set; }
        public static string C32 { get; set; }
        public static string C33 { get; set; }
        public static string C34 { get; set; }
        public static string C35 { get; set; }
        public static string C36 { get; set; }
        public int Port { get; private set; }
        public IPAddress LocalAddress { get; private set; }
        public static string Passwords { get; set; }

        #endregion

        public Server(int port)
        {
            Port = port;
            //change the string to your own ip
            LocalAddress = IPAddress.Parse("172.28.172.2");
        }

        public static void Listthem()
        {
            Console.WriteLine("Adding chunks to list");

            #region ADD TO LIST

            Clients.Add(C1);
            Clients.Add(C2);
            Clients.Add(C3);
            Clients.Add(C4);
            Clients.Add(C5);
            Clients.Add(C6);
            Clients.Add(C7);
            Clients.Add(C8);
            Clients.Add(C9);
            Clients.Add(C10);
            Clients.Add(C11);
            Clients.Add(C12);
            Clients.Add(C13);
            Clients.Add(C14);
            Clients.Add(C15);
            Clients.Add(C16);
            Clients.Add(C17);
            Clients.Add(C18);
            Clients.Add(C19);
            Clients.Add(C20);
            Clients.Add(C21);
            Clients.Add(C22);
            Clients.Add(C23);
            Clients.Add(C24);
            Clients.Add(C25);
            Clients.Add(C26);
            Clients.Add(C27);
            Clients.Add(C28);
            Clients.Add(C29);
            Clients.Add(C30);
            Clients.Add(C31);
            Clients.Add(C32);
            Clients.Add(C33);
            Clients.Add(C34);
            Clients.Add(C35);
            Clients.Add(C36);

            #endregion

            Console.WriteLine("Chunks added");
        }

        public static void Listen()
        {
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    try
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.WriteLine(Results[i]);
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("No data");
                        Console.WriteLine("");
                    }
                }
            }
            while (true);
        }
        public void Start()
        {
            // https://msdn.microsoft.com/en-us/library/system.net.sockets.tcplistener.aspx
            TcpListener server = new TcpListener(LocalAddress, Port);
            server.Start();
            Console.WriteLine("Echo TCP server started on " + LocalAddress + " port " + Port);

            const string file = @"C:\Users\javer\Desktop\Projects\EchoTcpServer\EchoTcpServer\webster-dictionary.txt";
            const string passwd = @"C:\Users\javer\Desktop\Projects\EchoTcpServer\EchoTcpServer\passwords.txt";
            using (StreamReader readpasswd = new StreamReader(passwd))
            {
                Passwords = readpasswd.ReadLine();
            }
            Thread hest = new Thread(Listen);

            hest.Start();

            using (StreamReader read = new StreamReader(file))
            {
                #region ADD PASSWORDS TO CHUNCK

                C1 = Passwords + "$";
                C2 = Passwords + "$";
                C3 = Passwords + "$";
                C4 = Passwords + "$";
                C5 = Passwords + "$";
                C6 = Passwords + "$";
                C7 = Passwords + "$";
                C8 = Passwords + "$";
                C9 = Passwords + "$";
                C10 = Passwords + "$";
                C11 = Passwords + "$";
                C12 = Passwords + "$";
                C13 = Passwords + "$";
                C14 = Passwords + "$";
                C15 = Passwords + "$";
                C16 = Passwords + "$";
                C17 = Passwords + "$";
                C18 = Passwords + "$";
                C19 = Passwords + "$";
                C20 = Passwords + "$";
                C21 = Passwords + "$";
                C22 = Passwords + "$";
                C23 = Passwords + "$";
                C24 = Passwords + "$";
                C25 = Passwords + "$";
                C26 = Passwords + "$";
                C27 = Passwords + "$";
                C28 = Passwords + "$";
                C29 = Passwords + "$";
                C30 = Passwords + "$";
                C31 = Passwords + "$";
                C32 = Passwords + "$";
                C33 = Passwords + "$";
                C34 = Passwords + "$";
                C35 = Passwords + "$";
                C36 = Passwords + "$";

                #endregion


                Console.WriteLine("Passwords added");
                Console.WriteLine("Adding dictionary to strings");


                #region ADD DICTIONARY TO STRING

                for (int i = 0; i < 311141; i++)
                {
                    C1 = C1 + "_" + read.ReadLine();
                    i++;
                    if (i != 311141)
                    {
                        C2 = C2 + "_" + read.ReadLine();
                        i++;
                        if (i != 311141)
                        {
                            C3 = C3 + "_" + read.ReadLine();
                            i++;
                            if (i != 311141)
                            {
                                C4 = C4 + "_" + read.ReadLine();
                                i++;
                                if (i != 311141)
                                {
                                    C5 = C5 + "_" + read.ReadLine();
                                    i++;
                                    if (i != 311141)
                                    {
                                        C6 = C6 + "_" + read.ReadLine();
                                        i++;
                                        if (i != 311141)
                                        {
                                            C7 = C7 + "_" + read.ReadLine();
                                            i++;
                                            if (i != 311141)
                                            {
                                                C8 = C8 + "_" + read.ReadLine();
                                                i++;
                                                if (i != 311141)
                                                {
                                                    C9 = C9 + "_" + read.ReadLine();
                                                    i++;
                                                    if (i != 311141)
                                                    {
                                                        C10 = C10 + "_" + read.ReadLine();
                                                        i++;
                                                        if (i != 311141)
                                                        {
                                                            C11 = C11 + "_" + read.ReadLine();
                                                            i++;
                                                            if (i != 311141)
                                                            {
                                                                C12 = C12 + "_" + read.ReadLine();
                                                                i++;
                                                                if (i != 311141)
                                                                {
                                                                    C13 = C13 + "_" + read.ReadLine();
                                                                    i++;
                                                                    if (i != 311141)
                                                                    {
                                                                        C14 = C14 + "_" + read.ReadLine();
                                                                        i++;
                                                                        if (i != 311141)
                                                                        {
                                                                            C15 = C15 + "_" + read.ReadLine();
                                                                            i++;
                                                                            if (i != 311141)
                                                                            {
                                                                                C16 = C16 + "_" + read.ReadLine();
                                                                                i++;
                                                                                if (i != 311141)
                                                                                {
                                                                                    C17 = C17 + "_" + read.ReadLine();
                                                                                    i++;
                                                                                    if (i != 311141)
                                                                                    {
                                                                                        C18 = C18 + "_" +
                                                                                              read.ReadLine();
                                                                                        i++;
                                                                                        if (i != 311141)
                                                                                        {
                                                                                            C19 = C19 + "_" +
                                                                                                  read.ReadLine();
                                                                                            i++;
                                                                                            if (i != 311141)
                                                                                            {
                                                                                                C20 = C20 + "_" +
                                                                                                      read.ReadLine();
                                                                                                i++;
                                                                                                if (i != 311141)
                                                                                                {
                                                                                                    C21 = C21 + "_" +
                                                                                                          read.ReadLine();
                                                                                                    i++;
                                                                                                    if (i != 311141)
                                                                                                    {
                                                                                                        C22 = C22 + "_" +
                                                                                                              read
                                                                                                                  .ReadLine
                                                                                                                  ();
                                                                                                        i++;
                                                                                                        if (i != 311141)
                                                                                                        {
                                                                                                            C23 = C23 +
                                                                                                                  "_" +
                                                                                                                  read
                                                                                                                      .ReadLine
                                                                                                                      ();
                                                                                                            i++;
                                                                                                            if (i !=
                                                                                                                311141)
                                                                                                            {
                                                                                                                C24 =
                                                                                                                    C24 +
                                                                                                                    "_" +
                                                                                                                    read
                                                                                                                        .ReadLine
                                                                                                                        ();
                                                                                                                i++;
                                                                                                                if (i !=
                                                                                                                    311141)
                                                                                                                {
                                                                                                                    C25
                                                                                                                        =
                                                                                                                        C25 +
                                                                                                                        "_" +
                                                                                                                        read
                                                                                                                            .ReadLine
                                                                                                                            ();
                                                                                                                    i++;
                                                                                                                    if (
                                                                                                                        i !=
                                                                                                                        311141)
                                                                                                                    {
                                                                                                                        C26
                                                                                                                            =
                                                                                                                            C26 +
                                                                                                                            "_" +
                                                                                                                            read
                                                                                                                                .ReadLine
                                                                                                                                ();
                                                                                                                        i
                                                                                                                            ++;
                                                                                                                        if
                                                                                                                            (
                                                                                                                            i !=
                                                                                                                            311141)
                                                                                                                        {
                                                                                                                            C27
                                                                                                                                =
                                                                                                                                C27 +
                                                                                                                                "_" +
                                                                                                                                read
                                                                                                                                    .ReadLine
                                                                                                                                    ();
                                                                                                                            i
                                                                                                                                ++;
                                                                                                                            if
                                                                                                                                (
                                                                                                                                i !=
                                                                                                                                311141)
                                                                                                                            {
                                                                                                                                C28
                                                                                                                                    =
                                                                                                                                    C28 +
                                                                                                                                    "_" +
                                                                                                                                    read
                                                                                                                                        .ReadLine
                                                                                                                                        ();
                                                                                                                                i
                                                                                                                                    ++;
                                                                                                                                if
                                                                                                                                    (
                                                                                                                                    i !=
                                                                                                                                    311141)
                                                                                                                                {
                                                                                                                                    C29
                                                                                                                                        =
                                                                                                                                        C29 +
                                                                                                                                        "_" +
                                                                                                                                        read
                                                                                                                                            .ReadLine
                                                                                                                                            ();
                                                                                                                                    i
                                                                                                                                        ++;
                                                                                                                                    if
                                                                                                                                        (
                                                                                                                                        i !=
                                                                                                                                        311141)
                                                                                                                                    {
                                                                                                                                        C30
                                                                                                                                            =
                                                                                                                                            C30 +
                                                                                                                                            "_" +
                                                                                                                                            read
                                                                                                                                                .ReadLine
                                                                                                                                                ();
                                                                                                                                        i
                                                                                                                                            ++;
                                                                                                                                        if
                                                                                                                                            (
                                                                                                                                            i !=
                                                                                                                                            311141)
                                                                                                                                        {
                                                                                                                                            C31
                                                                                                                                                =
                                                                                                                                                C31 +
                                                                                                                                                "_" +
                                                                                                                                                read
                                                                                                                                                    .ReadLine
                                                                                                                                                    ();
                                                                                                                                            i
                                                                                                                                                ++;
                                                                                                                                            if
                                                                                                                                                (
                                                                                                                                                i !=
                                                                                                                                                311141)
                                                                                                                                            {
                                                                                                                                                C32
                                                                                                                                                    =
                                                                                                                                                    C32 +
                                                                                                                                                    "_" +
                                                                                                                                                    read
                                                                                                                                                        .ReadLine
                                                                                                                                                        ();
                                                                                                                                                i
                                                                                                                                                    ++;
                                                                                                                                                if
                                                                                                                                                    (
                                                                                                                                                    i !=
                                                                                                                                                    311141)
                                                                                                                                                {
                                                                                                                                                    C33
                                                                                                                                                        =
                                                                                                                                                        C33 +
                                                                                                                                                        "_" +
                                                                                                                                                        read
                                                                                                                                                            .ReadLine
                                                                                                                                                            ();
                                                                                                                                                    i
                                                                                                                                                        ++;
                                                                                                                                                    if
                                                                                                                                                        (
                                                                                                                                                        i !=
                                                                                                                                                        311141)
                                                                                                                                                    {
                                                                                                                                                        C34
                                                                                                                                                            =
                                                                                                                                                            C34 +
                                                                                                                                                            "_" +
                                                                                                                                                            read
                                                                                                                                                                .ReadLine
                                                                                                                                                                ();
                                                                                                                                                        i
                                                                                                                                                            ++;
                                                                                                                                                        if
                                                                                                                                                            (
                                                                                                                                                            i !=
                                                                                                                                                            311141)
                                                                                                                                                        {
                                                                                                                                                            C35
                                                                                                                                                                =
                                                                                                                                                                C35 +
                                                                                                                                                                "_" +
                                                                                                                                                                read
                                                                                                                                                                    .ReadLine
                                                                                                                                                                    ();
                                                                                                                                                            i
                                                                                                                                                                ++;
                                                                                                                                                            if
                                                                                                                                                                (
                                                                                                                                                                i !=
                                                                                                                                                                311141)
                                                                                                                                                            {
                                                                                                                                                                C36
                                                                                                                                                                    =
                                                                                                                                                                    C36 +
                                                                                                                                                                    "_" +
                                                                                                                                                                    read
                                                                                                                                                                        .ReadLine
                                                                                                                                                                        ();
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                #endregion

                Console.WriteLine("Dictionary are done initializing");

                Listthem();

                Console.WriteLine("Server started ...");
            }

            while (true)

            {
                TcpClient client = server.AcceptTcpClient();
                DoIt(client);
            }
        }

        private static void DoIt(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                String message = reader.ReadLine(); // echo is a line based protocol
                                                    //String response = request; // this is echo!
                                                    //StreamWriter writer = new StreamWriter(stream);
                                                    //writer.WriteLine(response);
                                                    //writer.Flush();

                //Console.WriteLine(message + " received from " + client.Client.RemoteEndPoint);
                string[] checkm8 = message.Split(' ');
                string checkedm8 = checkm8[0];

                var ayy = "";
                switch (checkedm8)
                {
                    case "RES":
                        ayy = "result saved";
                        string[] result = checkm8[1].Split('$', ',');
                        Console.WriteLine("request " + checkedm8);
                        Console.WriteLine("result: " + result[0] + " " + result[1] + " " + result[2]);
                        Console.WriteLine("");
                        Results.Add(result[0] + " " + result[1] + " " + result[2]);
                        break;
                    case "GET":
                        ayy = Clients[0];
                        Clients.RemoveAt(0);
                        Console.WriteLine("Chunks remaining: " + Clients.Count);
                        Console.WriteLine("request " + checkedm8);
                        if (Clients.Count == 0)
                        {
                            Listthem();
                        }
                        Console.WriteLine("");
                        break;
                    default:
                        ayy = "Invalid Request";
                        Console.WriteLine("");
                        break;
                }


                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(ayy);
                writer.Flush();
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }
    }
}
