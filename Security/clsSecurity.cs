using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class clsSecurity
{
    // ==========================================
    // 1. Hashing (SHA-256) - كلمة السر بالداتا بيز
    // ==========================================
    public static string ComputeHash(string input)
    {
            using (SHA256 sha256 = SHA256.Create())
            {
                // استخدام Unicode مطابِق لترميز SQL Server
                byte[] hashBytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(input));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            
            }
    }

    // ==========================================
    // 2. Symmetric Encryption (AES-256) - خيار تذكرني
    // ==========================================
    private static readonly string Key = "12345678901234567890123456789012"; // مفتاح 32 Byte (256-bit)

    public static string EncryptText(string plainText)
    {
        if (string.IsNullOrEmpty(plainText)) return "";

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(Key);
            aes.IV = new byte[16]; // IV ثابت للتبسيط

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }

    public static string DecryptText(string cipherText)
    {
        if (string.IsNullOrEmpty(cipherText)) return "";

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(Key);
            aes.IV = new byte[16];

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }
    }
}