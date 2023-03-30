using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VLogica.Modelos
{
    public class Crypto
    {

        string LlavePersonalizada = "VetProyect/kajhsdkjh672716762";

        public string DesEncriptarContrasena(string Contrasena)
        {
            String R = string.Empty;

            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    Byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(LlavePersonalizada));

                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;

                    Byte[] data = Convert.FromBase64String(Contrasena);

                    R = Encoding.UTF8.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));

                }
            }

            return R;

        }

        public string EncriptarContrasena(string Contrasena)
        {
            String R = string.Empty;

            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    Byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(LlavePersonalizada));

                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;

                    Byte[] data = Encoding.UTF8.GetBytes(Contrasena);

                    R = Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));

                }
            }

            return R;

        }

        public string EncriptarEnUnSentido(string Entrada)
        {
            string PorEncriptar = EncriptarContrasena(Entrada);

            PorEncriptar += "PalabraClave";

            SHA256CryptoServiceProvider ProveedorCrypto = new SHA256CryptoServiceProvider();

            byte[] BytesDeEntrada = Encoding.UTF8.GetBytes(PorEncriptar);

            byte[] BytesConHash = ProveedorCrypto.ComputeHash(BytesDeEntrada);

            StringBuilder Resultado = new StringBuilder();

            for (int i = 0; i < BytesConHash.Length; i++)
                Resultado.Append(BytesConHash[i].ToString("x2").ToLower());
            return Resultado.ToString();

        }
    }
}
