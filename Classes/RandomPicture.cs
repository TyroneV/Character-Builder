using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Character_Builder
{
    class RandomPicture : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<string> GetRandomImage()
        {
            string filePath = 
                $@"{AppDomain.CurrentDomain.BaseDirectory}\pictures";
            string finalPath;
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            string Uri = "https://picsum.photos/200";
            using (WebClient client = new WebClient())
            {
                try
                {
                    finalPath = filePath + @"\random.jpg";
                    await client.DownloadFileTaskAsync(
                        new Uri(Uri), finalPath);

                } catch (Exception)
                {
                    finalPath = filePath + @"\random2.jpg";
                    await client.DownloadFileTaskAsync(
                        new Uri(Uri), finalPath);

                }
            }
            return finalPath;
        }
        
    }
}
