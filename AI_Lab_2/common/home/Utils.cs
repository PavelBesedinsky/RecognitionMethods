namespace AI_Lab_2.common.home
{
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Utils" />
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// The ReadJson
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        static public string ReadJson()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return "Error";
            string fileText = System.IO.File.ReadAllText(openFileDialog.FileName);
            return fileText;
        }

        /// <summary>
        /// The ReadJson
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/></param>
        /// <returns>The <see cref="string"/></returns>
        static public string ReadJson(string filename)
        {
            string fileText = System.IO.File.ReadAllText(filename);
            return fileText;
        }
    }
}
