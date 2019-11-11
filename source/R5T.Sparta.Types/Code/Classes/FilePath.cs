using System;

using R5T.Stagira;


namespace R5T.Sparta
{
    public class FilePath : TypedString
    {
        #region Static

        public static FilePath New(string filePath)
        {
            var output = new FilePath(filePath);
            return output;
        }

        #endregion


        public FilePath(string value)
            : base(value)
        {
        }
    }
}
