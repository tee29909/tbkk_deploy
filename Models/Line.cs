using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public  class Line
    {

        public  void notifyPicture(string msg, string url, string TOKEN)

        {

            _lineNotify(msg, 0, 0, url, TOKEN);

        }

        public  void notifySticker(string msg, int stickerID, int stickerPackageID, string TOKEN)

        {

            _lineNotify(msg, stickerPackageID, stickerID, "", TOKEN);

        }

        public  void lineNotify(string msg, string TOKEN)

        {

            _lineNotify(msg, 0, 0, "", TOKEN);

        }

        public  void _lineNotify(string msg, int stickerPackageID, int stickerID, string pictureUrl, string TOKEN)

        {

            string token = TOKEN;

            try

            {

                var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");



                var postData = string.Format("message={0}", msg);

                if (stickerPackageID > 0 && stickerID > 0)

                {

                    var stickerPackageId = string.Format("stickerPackageId={0}", stickerPackageID);

                    var stickerId = string.Format("stickerId={0}", stickerID);

                    postData += "&" + stickerPackageId.ToString() + "&" + stickerId.ToString();

                }

                if (pictureUrl != "")

                {

                    var imageThumbnail = string.Format("imageThumbnail={0}", pictureUrl);

                    var imageFullsize = string.Format("imageFullsize={0}", pictureUrl);

                    postData += "&" + imageThumbnail.ToString() + "&" + imageFullsize.ToString();

                }

                var data = Encoding.UTF8.GetBytes(postData);



                request.Method = "POST";

                request.ContentType = "application/x-www-form-urlencoded";

                request.ContentLength = data.Length;

                request.Headers.Add("Authorization", "Bearer " + token);



                using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

        }
    }
}
