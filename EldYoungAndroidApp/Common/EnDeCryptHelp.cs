using System;
using System.Security.Cryptography;
using System.Text;

namespace EldYoungAndroidApp.Common
{
	public class EnDeCryptHelp
	{
		public EnDeCryptHelp ()
		{
		}
		#region ========加密========

		/// <summary>
		/// 加密
		/// </summary>
		/// <param name="Text"></param>
		/// <returns></returns>
		public static string Encrypt(string Text)
		{
			return Encrypt(Text, "MATICSOFT");
		}
		/// <summary> 
		/// 加密数据 
		/// </summary> 
		/// <param name="Text"></param> 
		/// <param name="sKey"></param> 
		/// <returns></returns> 
		public static string Encrypt(string Text, string sKey)
		{
			DESCryptoServiceProvider des = new DESCryptoServiceProvider();
			byte[] inputByteArray;
			//inputByteArray = Encoding.Default.GetBytes(Text);
			//inputByteArray = Encoding.UTF8.GetBytes(Text);
			inputByteArray=Encoding.GetEncoding ("gb2312").GetBytes (Text);

//			des.Key = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0,8));
//			des.IV = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0,8));
			des.Key = System.Text.Encoding.UTF8.GetBytes(sKey.Substring(0,8));
			des.IV = System.Text.Encoding.UTF8.GetBytes(sKey.Substring(0,8));
			System.IO.MemoryStream ms = new System.IO.MemoryStream();
			CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
			cs.Write(inputByteArray, 0, inputByteArray.Length);
			cs.FlushFinalBlock();
			StringBuilder ret = new StringBuilder();
			foreach (byte b in ms.ToArray())
			{
				ret.AppendFormat("{0:X2}", b);
			}
			return ret.ToString();
		}

		#endregion

		#region ========解密========


		/// <summary>
		/// 解密
		/// </summary>
		/// <param name="Text"></param>
		/// <returns></returns>
		public static string Decrypt(string Text)
		{
			return Decrypt(Text, "MATICSOFT");
		}
		/// <summary> 
		/// 解密数据 
		/// </summary> 
		/// <param name="Text"></param> 
		/// <param name="sKey"></param> 
		/// <returns></returns> 
		public static string Decrypt(string Text, string sKey)
		{
			DESCryptoServiceProvider des = new DESCryptoServiceProvider();
			int len;
			len = Text.Length / 2;
			byte[] inputByteArray = new byte[len];
			int x, i;
			for (x = 0; x < len; x++)
			{
				i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
				inputByteArray[x] = (byte)i;
			}

//			des.Key = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0,8));
//			des.IV = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0,8));
			des.Key = System.Text.Encoding.UTF8.GetBytes(sKey.Substring(0,8));
			des.IV = System.Text.Encoding.UTF8.GetBytes(sKey.Substring(0,8));
			System.IO.MemoryStream ms = new System.IO.MemoryStream();
			CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
			cs.Write(inputByteArray, 0, inputByteArray.Length);
			cs.FlushFinalBlock();
			return Encoding.Default.GetString(ms.ToArray());
		}

		#endregion


		public static string MD5Encrypt(string sDataIn, string move)
		{
			System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
			byte[] byt, bytHash;
			byt = System.Text.Encoding.UTF8.GetBytes(move + sDataIn);
			bytHash = md5.ComputeHash(byt);
			md5.Clear();
			string sTemp = "";
			for (int i = 0; i < bytHash.Length; i++)
			{
				sTemp += bytHash[i].ToString("x").PadLeft(2, '0');
			}
			return sTemp;
		}
	}
}

