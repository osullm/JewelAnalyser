using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace JewelApp01.Processer
{
    class EncryptionHelper
    {

        private static string key = "ae125efkk4454eeff4*#ferfkny6oxi8";
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="encryptStr">明文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Encrypt(string encryptStr)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(encryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="decryptStr">密文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Decrypt(string decryptStr)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = Convert.FromBase64String(decryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }


        private void test()
        {
            string encryptStr, decryptStr, key;
            key = "ae125efkk4454eeff444ferfkny6oxi8";
            encryptStr = "C#AES加密字符串";
            //richTextBox1.AppendText("==============  256位AES加密  ============\n");
            //richTextBox1.AppendText("加密前的字符串：" + encryptStr + "\n");
            //richTextBox1.AppendText("密钥：" + key + "\n");
            //decryptStr = EncryptionHelper.Encrypt(encryptStr, key);
            //richTextBox1.AppendText("加密后的字符串：" + decryptStr + "\n");
            //encryptStr = EncryptionHelper.Decrypt(decryptStr, key);
            //richTextBox1.AppendText("解密后的字符串：" + encryptStr + "\n");
        }

    }



}
