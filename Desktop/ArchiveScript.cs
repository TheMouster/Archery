using System;
using System.IO;
using System.Xml.Serialization;

namespace ClassifiedDevelopment.Archery
{
    /// <summary>
    /// The ArchiveScript object. Represents a source and destination for a directory archiving process.
    /// </summary>
    [Serializable()]
    public class ArchiveScript
    {
        [XmlElement]
        public String Source { get; set; } = String.Empty;

        [XmlElement]
        public String Destination { get; set; } = String.Empty;
        //TODO: If the destination path contains ##FILEDATE## then replace it with a file-date e.g. "2015-11-02 1700"
        //TODO: Modify the Destination property to have a full set statement to accomplish this.

        /// <summary>
        /// Loads an ArchiveScript from a supplied Archery file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>An ArchiveScript object</returns>
        public static ArchiveScript LoadFromFile(String fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(ArchiveScript));
                return (ArchiveScript)xml.Deserialize(stream);
            }
        }
    }
}
