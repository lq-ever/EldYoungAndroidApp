using System;
using System.Net;
using System.IO;
using System.Text;

namespace EldYoungAndroidApp.Common
{
	public class HttpWebRequestHelper
	{
		const string contentType = "application/x-www-form-urlencoded";
		public HttpWebRequestHelper ()
		{
			
		}

		/// <summary>
		/// 使用rest方式 获取web服务端数据
		/// </summary>
		/// <param name="cookie">Cookie.</param>
		/// <param name="postUrl">Post URL.</param>
		/// <param name="postData">Post data.</param>
		/// <param name="callback">Callback.</param>
		public static void SendHttpPostRequest(string postUrl,string postData,Action<HttpWebResponse> callback)
		{

			var request = HttpWebRequest.Create (postUrl) as HttpWebRequest;
			request.Method = "POST";

			//设置postdata数据
			if (!string.IsNullOrEmpty (postData)) {
				request.ContentLength = postData.Length;
				request.ContentType = contentType;

				request.BeginGetRequestStream ((ar) => {

					var syncrequest =(HttpWebRequest)ar.AsyncState;
					using(var writer = new StreamWriter(syncrequest.EndGetRequestStream(ar)))
						{
						  writer.Write(postData);
						  writer.Close();
						}
					syncrequest.BeginGetResponse((asyncResult =>
						{
							var httpwebRequest = (HttpWebRequest) asyncResult.AsyncState;
							using (var response = httpwebRequest.EndGetResponse(asyncResult) as HttpWebResponse)
							{
								callback(response);
							}

						}),syncrequest);

					
				},request);
					
					
			}



		}

		/// <summary>
		/// 通过httpwebresponse获取返回值
		/// </summary>
		/// <returns>The text from resopnse.</returns>
		/// <param name="response">Response.</param>
		public static StreamReader GetStreamReaderFromResopnse(HttpWebResponse response)
		{
//			if (response != null) {
//
//				using (var reader = new StreamReader (response.GetResponseStream (), Encoding.UTF8)) {
//					
//					return reader.ReadToEnd ();
//				}
//			}
//			return string.Empty;

			if (response != null) {

				return	new StreamReader (response.GetResponseStream (), Encoding.UTF8);
			}
			return null;
		}
	}
}

