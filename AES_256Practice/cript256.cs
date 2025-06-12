using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AES_256Practice
{
    public class cript256
    {
        // Encripta texto plano agregando una firma
        public byte[] Encrypt(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    // Agrega una firma de validación
                    sw.Write("||VALID||" + plainText);
                    sw.Flush();
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }

        // Desencripta y valida la firma del mensaje
        public string Decrypt(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream(cipherText))
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    string decryptedText = sr.ReadToEnd();

                    // Verifica la firma
                    if (!decryptedText.StartsWith("||VALID||"))
                    {
                        throw new CryptographicException("Firma de validación no encontrada. Clave o IV incorrectos.");
                    }

                    // Retorna el texto sin la firma
                    return decryptedText.Substring("||VALID||".Length);
                }
            }
        }

        public byte[] thirteen()
        {
            byte[] key = new byte[32]; // 256 bits
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
            }
            return key;
        }

        public byte[] sixTeen()
        {
            byte[] iv = new byte[16]; // 128 bits
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(iv);
            }
            return iv;
        }
    }
}

