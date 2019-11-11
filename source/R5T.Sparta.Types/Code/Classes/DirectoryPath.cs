using System;

using R5T.Stagira;


namespace R5T.Sparta
{
    public class DirectoryPath : TypedString
    {
        #region Static

        public static DirectoryPath New(string directoryPath)
        {
            var output = new DirectoryPath(directoryPath);
            return output;
        }

        #endregion


        public DirectoryPath(string value)
            : base(value)
        {
        }
    }
}
