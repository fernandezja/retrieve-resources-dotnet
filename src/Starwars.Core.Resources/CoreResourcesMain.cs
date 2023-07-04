using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Starwars.Core.Resources
{
    public class CoreResourcesMain
    {


        public string GetInformationalVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);

            if (customAttributes.Length > 0)
            {
                AssemblyInformationalVersionAttribute informationalVersionAttribute = (AssemblyInformationalVersionAttribute)customAttributes[0];
                return informationalVersionAttribute.InformationalVersion;
            }

            return string.Empty;
        }


        public string GetResources2ContentLeiaQuotes()
        {
            //
            //var assemblyLocation = Assembly.GetExecutingAssembly().Location;
            //var directoryPath = Path.GetDirectoryName(assemblyLocation);
            // string filePath = Path.Combine(directoryPath, @"Resources2Content\LeiaQuotes.txt");


            //
            //string filePath = Path.Combine(Environment.CurrentDirectory, @"Resources2Content\LeiaQuotes.txt");


            return GetResources2ContentLeiaQuotes(directoryPath: AppDomain.CurrentDomain.BaseDirectory);

        }


        public string GetResources2ContentLeiaQuotes(string directoryPath)
        {

            if (!IsDirectoryPath(directoryPath))
            {
                throw new ArgumentException("Invalid directoryPath");
            }


            string filePath = Path.Combine(directoryPath, @"Resources2Content\LeiaQuotes.txt");

            using (var reader = new StreamReader(filePath))
            {
                if (reader != null)
                {
                    return reader.ReadToEnd();
                }
                else
                {
                    throw new Exception("Resource not found");
                }
            }

        }


        public byte[] GetResources2ContentLeiaImage()
        {
            return GetResources2ContentLeiaImage(directoryPath: AppDomain.CurrentDomain.BaseDirectory);
        }


        public byte[] GetResources2ContentLeiaImage(string directoryPath)
        {

            if (!IsDirectoryPath(directoryPath))
            {
                throw new ArgumentException("Invalid directoryPath");
            }


            string filePath = Path.Combine(directoryPath, @"Resources2Content\Leia001.jpg");

            if (File.Exists(filePath))
            {
                return File.ReadAllBytes(filePath);
            }
            else
            {
                throw new Exception("Resource not found");
            }

        }


        public string GetResources3EmbeddedResourceDarthVaderQuotes()
        {
            var assembly = Assembly.GetExecutingAssembly();

            string fileName = "Starwars.Core.Resources.Resources3EmbeddedResource.DarthVaderQuotes.txt";

            using (var stream = assembly.GetManifestResourceStream(fileName))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
                else
                {
                    throw new Exception("Resource not found");
                }
            }

        }



        public byte[] GetResources3EmbeddedResourceDarthVaderImage()
        {
            var assembly = Assembly.GetExecutingAssembly();

            string fileName = "Starwars.Core.Resources.Resources3EmbeddedResource.DarthVader001.jpg";

            using (var stream = assembly.GetManifestResourceStream(fileName))
            {
                if (stream != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        stream.CopyTo(memoryStream);
                        return memoryStream.ToArray();
                    }
                }
                else
                {
                    throw new Exception("Resource not found");
                }
            }

        }



        public bool IsDirectoryPath(string path)
        {
            string directoryName = Path.GetDirectoryName(path);

            bool isDirectoryPath = !string.IsNullOrEmpty(directoryName);

            return isDirectoryPath;
        }
    }
}
