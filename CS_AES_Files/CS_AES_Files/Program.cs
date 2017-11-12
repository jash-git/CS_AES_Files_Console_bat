using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CS_AES_Files
{
    class Program
    {
        static void Pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            String inputFile;
            String outputFile;
            String mode;
            String password;

            inputFile = "te.png";// "Program.cs";
            outputFile = "test_e.png";//"Program_e.cs";
            mode = "enc";
            password = "P@$$WORD";
            
            if (args.Length == 1)
            {
                SecureAES aes = new SecureAES();
                try
                {
                    string[] strs = args[0].Split(',');
                    inputFile = strs[0];
                    outputFile = strs[1];
                    mode = strs[2].ToLower();
                    password = strs[3];
                    if (mode == "enc")
                    {
                        aes.AES_Encrypt(inputFile, password, outputFile);
                    }
                    if (mode == "dec")
                    {
                        aes.AES_Decrypt(inputFile, password, outputFile);
                    }
                    Console.WriteLine("工作完成");
                }
                catch
                {
                    Console.WriteLine("目前參數:");
                    for (int i = 0; i < args.Length; i++)
                    {
                        Console.WriteLine(i + ":\t" + args[i]);
                    }
                    Console.WriteLine("沒有對應參數，無法工作");
                    Console.WriteLine("參數格式:要被轉換的檔案名稱，輸出的檔案名稱，Enc/Dec，密碼");
                }
            }
            else
            {
                Console.WriteLine("目前參數:");
                for(int i=0;i< args.Length;i++)
                {
                    Console.WriteLine(i+":\t"+ args[i]);
                }
                Console.WriteLine("沒有對應參數，無法工作");
                Console.WriteLine("參數格式:要被轉換的檔案名稱，輸出的檔案名稱，Enc/Dec，密碼");
            }
            Pause();
        }
    }
}
